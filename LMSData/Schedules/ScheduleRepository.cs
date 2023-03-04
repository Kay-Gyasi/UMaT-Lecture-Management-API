namespace LMSData.Schedules;

[Repository]
public class ScheduleRepository : Repository<Schedule, int>, IScheduleRepository
{
    public ScheduleRepository(AppDbContext context, ILogger<Repository<Schedule, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface IScheduleRepository : IRepository<Schedule, int> { }