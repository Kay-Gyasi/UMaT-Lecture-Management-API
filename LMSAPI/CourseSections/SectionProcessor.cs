namespace LMSAPI.CourseSections;

public record SectionCommand(int Id, int ActivityId, SectionType Type);

public record SectionDto(int Id, int ActivityId, ActivityDto Activity, SectionType Type, 
    IEnumerable<LecturerDto> Lecturers, IEnumerable<SessionDto> Sessions);

public record SectionPageDto(int Id, int ActivityId, SectionType Type, ActivityPageDto Activity);

[Processor]
public class SectionProcessor
{
    private readonly ISectionRepository _sectionRepository;

    public SectionProcessor(ISectionRepository sectionRepository)
    {
        _sectionRepository = sectionRepository;
    }
    
    public async Task<int> UpsertAsync(SectionCommand command)
    {
        var isNew = command.Id == 0;
        Section? section;

        if (isNew)
        {
            section = Section.Create()
                .OfType(command.Type)
                .OnActivity(command.ActivityId);
            await _sectionRepository.AddAsync(section);
            return section.Id;
        }

        section = await _sectionRepository.FindByIdAsync(command.Id);
        if(section is null) throw new NullReferenceException();

        section.OfType(command.Type)
            .OnActivity(command.ActivityId);
        await _sectionRepository.UpdateAsync(section);
        return section.Id;
    }

    public async Task<SectionDto> GetAsync(int id)
    {
        var section = await _sectionRepository.FindByIdAsync(id);
        if (section is null) throw new NullReferenceException();

        return section.Adapt<SectionDto>();
    }

    public async Task<PaginatedList<SectionPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _sectionRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<SectionPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var section = await _sectionRepository.FindByIdAsync(id);
        if (section is null) throw new NullReferenceException();

        await _sectionRepository.SoftDeleteAsync(section);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var section = await _sectionRepository.FindByIdAsync(id);
        if (section is null) throw new NullReferenceException();

        await _sectionRepository.DeleteAsync(section);
    }
}