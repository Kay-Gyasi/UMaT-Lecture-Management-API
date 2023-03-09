using LMSData.Students;
using Microsoft.AspNetCore.Identity;

namespace LMSAPI.Users.Students;

public record StudentCommand(int Id, int UserId, int? ClassId, UserCommand? User);
public record StudentDto(int Id, int UserId, int ClassId, UserDto User, ClassDto Class);
public record StudentPageDto(int Id, int UserId, int ClassId, UserPageDto User, ClassPageDto Class);

[Processor]
public class StudentProcessor
{
    private readonly IStudentRepository _studentRepository;
    private readonly UserManager<User> _userManager;

    public StudentProcessor(IStudentRepository studentRepository, UserManager<User> userManager)
    {
        _studentRepository = studentRepository;
        _userManager = userManager;
    }
    
    public async Task<int> UpsertAsync(StudentCommand command)
    {
        var isNew = command.Id == 0;
        Student? student;

        if (isNew)
        {
            student = Student.Create(command.ClassId)
                .IsUser(command.UserId);
            await _studentRepository.AddAsync(student);
            return student.Id;
        }
        
        student = await _studentRepository.FindByIdAsync(command.Id);
        if(student is null) throw new NullReferenceException();

        var user = await _userManager.FindByIdAsync(command.UserId.ToString());
        if(user is null) throw new NullReferenceException();

        student.IsUser(command.UserId)
            .IsInClass(command.ClassId);
        student.User.WithEmail(command.User?.Email)
            .WithPhone(command.User?.PhoneNumber)
            .WasBornOn(command.User?.DateOfBirth)
            .HasUserName(string.Join(" ", command.User?.FirstName, command.User?.LastName))
            .HasFirstName(command.User?.FirstName)
            .HasLastName(command.User?.LastName);
        await _studentRepository.UpdateAsync(student);
        return student.Id;
    }

    public async Task<StudentDto> GetAsync(int id)
    {
        var lecturer = await _studentRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        return lecturer.Adapt<StudentDto>();
    }

    public async Task<PaginatedList<StudentPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _studentRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<StudentPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var lecturer = await _studentRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        await _studentRepository.SoftDeleteAsync(lecturer);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var lecturer = await _studentRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        await _studentRepository.DeleteAsync(lecturer);
    }
}