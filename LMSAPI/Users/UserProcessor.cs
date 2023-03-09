using LMSAPI.Users.Lecturers;
using LMSAPI.Users.Students;
using Microsoft.AspNetCore.Identity;

namespace LMSAPI.Users;

public record SignupCommand(UserType Type, string FirstName, string LastName, 
    string? Email, string? PhoneNumber, string Password);

public record LoginCommand(string Email, string Password);

public record UserCommand(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);

public record UserDto(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);

public record UserPageDto(int Id, UserType Type, string FirstName, string LastName, DateTime? DateOfBirth,
    string? UserName, string? Email, string? PhoneNumber);

[Processor]
public class UserProcessor
{
    private readonly LecturerProcessor _lecturerProcessor;
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;
    private readonly ILogger<UserProcessor> _logger;
    private readonly StudentProcessor _studentProcessor;
    private readonly ILecturerRepository _lecturerRepository;

    public UserProcessor(LecturerProcessor lecturerProcessor, UserManager<User> userManager,
        ITokenService tokenService, ILogger<UserProcessor> logger, StudentProcessor studentProcessor,
        ILecturerRepository lecturerRepository)
    {
        _lecturerProcessor = lecturerProcessor;
        _userManager = userManager;
        _tokenService = tokenService;
        _logger = logger;
        _studentProcessor = studentProcessor;
        _lecturerRepository = lecturerRepository;
    }
    
    public async Task<UserDto> GetAsync(int id)
    {
        var lecturer = await _userManager.FindByIdAsync(id.ToString());
        if (lecturer is null) throw new NullReferenceException();

        return lecturer.Adapt<UserDto>();
    }

    public async Task<AuthToken> LoginAsync(LoginCommand command)
    {
        var user = await _userManager.FindByEmailAsync(command.Email);

        if (user is null || !await _userManager.CheckPasswordAsync(user, command.Password))
        {
            throw new InvalidLoginException();
        }

        return await _tokenService.GenerateToken(user);
    }

    public async Task<int?> Save(SignupCommand command)
    {
        if (command is null) throw new NullReferenceException();
        var user = User.Create(command.Type, command.FirstName, command.LastName)
            .HasUserName(string.Join(" ", command.FirstName, command.LastName))
            .WithEmail(command.Email)
            .WithPhone(command.PhoneNumber);
        
        var result = await _userManager.CreateAsync(user, command.Password);
        if (result.Errors.Any())
        {
            _logger.LogError("{Errors}", result.Errors.ToString());
            throw new InvalidDataException();
        }

        int? id;

        await using var transaction = await _lecturerRepository.BeginTransaction();

        try
        {
            switch (command?.Type)
            {
                case UserType.Lecturer:
                    await _userManager.AddToRoleAsync(user, UserType.Lecturer.ToString());
                    id = await _lecturerProcessor.UpsertAsync(new LecturerCommand(Id: 0, DepartmentId: null, 
                        UserId: user.Id, User: null));
                    break;
                case UserType.Student:
                    await _userManager.AddToRoleAsync(user, UserType.Student.ToString());
                    id = await _studentProcessor.UpsertAsync(new StudentCommand(Id: 0, ClassId: null, 
                        UserId: user.Id, User: null));
                    break;
                case UserType.Developer:
                    await _userManager.AddToRoleAsync(user, UserType.Developer.ToString());
                    id = user.Id;
                    break;
                case UserType.Admin:
                    await _userManager.AddToRoleAsync(user, UserType.Admin.ToString());
                    id = user.Id;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            await transaction.CommitAsync();
        }
        catch (Exception e)
        {
            await transaction.RollbackAsync();
            _logger.LogError("{Message}", e.Message);
            throw;
        }
        
        return id;
    }
}