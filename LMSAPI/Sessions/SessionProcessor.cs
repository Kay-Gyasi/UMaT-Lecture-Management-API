namespace LMSAPI.Sessions;

public record SessionCommand(int Id, int SectionId, int RoomId, double StartTimeWithWeekday, double EndTimeWithWeekday);

public record SessionDto(int Id, int SectionId, int RoomId, double StartTimeWithWeekday, 
    double EndTimeWithWeekday, SectionDto Section, RoomDto Room);

public record SessionPageDto(int Id, int SectionId, int RoomId, double StartTimeWithWeekday, 
    double EndTimeWithWeekday, SectionPageDto Section, RoomPageDto Room);

[Processor]
public class SessionProcessor
{
    private readonly ISessionRepository _sessionRepository;

    public SessionProcessor(ISessionRepository sessionRepository)
    {
        _sessionRepository = sessionRepository;
    }
    
    public async Task<int> UpsertAsync(SessionCommand command)
    {
        var isNew = command.Id == 0;
        Session? session;

        if (isNew)
        {
            session = Session.Create(command.SectionId, command.RoomId);
            session.SetEndTimeWithWeekday(command.EndTimeWithWeekday)
                .SetStartTimeWithWeekday(command.StartTimeWithWeekday);
            await _sessionRepository.AddAsync(session);
            return session.Id;
        }

        session = await _sessionRepository.FindByIdAsync(command.Id);
        if(session is null) throw new NullReferenceException();

        session.ToBeHeldIn(command.RoomId)
            .ForSection(command.SectionId)
            .SetEndTimeWithWeekday(command.EndTimeWithWeekday)
            .SetStartTimeWithWeekday(command.StartTimeWithWeekday);
        await _sessionRepository.UpdateAsync(session);
        return session.Id;
    }

    public async Task<SessionDto> GetAsync(int id)
    {
        var session = await _sessionRepository.FindByIdAsync(id);
        if (session is null) throw new NullReferenceException();

        return session.Adapt<SessionDto>();
    }

    public async Task<PaginatedList<SessionPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _sessionRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<SessionPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var session = await _sessionRepository.FindByIdAsync(id);
        if (session is null) throw new NullReferenceException();

        await _sessionRepository.SoftDeleteAsync(session);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var session = await _sessionRepository.FindByIdAsync(id);
        if (session is null) throw new NullReferenceException();

        await _sessionRepository.DeleteAsync(session);
    }
}