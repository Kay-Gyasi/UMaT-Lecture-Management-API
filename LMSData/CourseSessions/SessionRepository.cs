namespace LMSData.CourseSessions;

public class SessionRepository : Repository<Session, int>, ISessionRepository
{
    public SessionRepository(AppDbContext context, ILogger<Repository<Session, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface ISessionRepository : IRepository<Session, int> { }