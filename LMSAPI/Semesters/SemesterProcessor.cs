namespace LMSAPI.Semesters;

public record SemesterCommand(int Id, DateTime StartDate, DateTime EndDate);
public record SemesterDto(int Id, DateTime StartDate, DateTime EndDate, SemesterType Type);
public record SemesterPageDto(int Id, DateTime StartDate, DateTime EndDate, SemesterType Type);

[Processor]
public class SemesterProcessor
{
    private readonly ISemesterRepository _semesterRepository;

    public SemesterProcessor(ISemesterRepository semesterRepository)
    {
        _semesterRepository = semesterRepository;
    }
    
    public async Task<int> UpsertAsync(SemesterCommand command)
    {
        var isNew = command.Id == 0;
        Semester? semester;

        if (isNew)
        {
            semester = Semester.Create(command.StartDate, command.EndDate, null);
            await _semesterRepository.AddAsync(semester);
            return semester.Id;
        }

        semester = await _semesterRepository.FindByIdAsync(command.Id);
        if(semester is null) throw new NullReferenceException();

        semester.StartsOn(command.StartDate)
            .EndsOn(command.EndDate);
        await _semesterRepository.UpdateAsync(semester);
        return semester.Id;
    }

    public async Task<ClassDto> GetAsync(int id)
    {
        var semester = await _semesterRepository.FindByIdAsync(id);
        if (semester is null) throw new NullReferenceException();

        return semester.Adapt<ClassDto>();
    }

    public async Task<PaginatedList<ClassPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _semesterRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<ClassPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var semester = await _semesterRepository.FindByIdAsync(id);
        if (semester is null) throw new NullReferenceException();

        await _semesterRepository.SoftDeleteAsync(semester);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var semester = await _semesterRepository.FindByIdAsync(id);
        if (semester is null) throw new NullReferenceException();

        await _semesterRepository.DeleteAsync(semester);
    }
}