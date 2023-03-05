using Microsoft.AspNetCore.Identity;

namespace LMSAPI.Lecturers;

public record LecturerCommand(int Id, int DepartmentId, int UserId, UserCommand User);

public record LecturerDto(int Id, int DepartmentId, int UserId, UserDto User, IEnumerable<Section> Sections);

public record LecturerPageDto(int Id, int DepartmentId, int UserId, UserPageDto User);

[Processor]
public class LecturerProcessor
{
    private readonly ILecturerRepository _lecturerRepository;
    private readonly UserManager<User> _userManager;

    public LecturerProcessor(ILecturerRepository lecturerRepository, UserManager<User> userManager)
    {
        _lecturerRepository = lecturerRepository;
        _userManager = userManager;
    }
    
    public async Task<int> UpsertAsync(LecturerCommand command)
    {
        var isNew = command.Id == 0;
        Lecturer? lecturer;

        if (isNew)
        {
            lecturer = Lecturer.Create(User.Create(command.User.Type, command.User.FirstName, command.User.LastName))
                .BelongsTo(command.DepartmentId);
            await _lecturerRepository.AddAsync(lecturer);
            return lecturer.Id;
        }

        lecturer = await _lecturerRepository.FindByIdAsync(command.Id);
        if(lecturer is null) throw new NullReferenceException();

        var user = await _userManager.FindByIdAsync(command.UserId.ToString());
        if(user is null) throw new NullReferenceException();

        lecturer.IsUser(user)
            .BelongsTo(command.DepartmentId);
        await _lecturerRepository.UpdateAsync(lecturer);
        return lecturer.Id;
    }

    public async Task<LecturerDto> GetAsync(int id)
    {
        var lecturer = await _lecturerRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        return lecturer.Adapt<LecturerDto>();
    }

    public async Task<PaginatedList<LecturerPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _lecturerRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<LecturerPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var lecturer = await _lecturerRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        await _lecturerRepository.SoftDeleteAsync(lecturer);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var lecturer = await _lecturerRepository.FindByIdAsync(id);
        if (lecturer is null) throw new NullReferenceException();

        await _lecturerRepository.DeleteAsync(lecturer);
    }
}