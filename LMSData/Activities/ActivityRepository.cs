namespace LMSData.Activities;

public class ActivityRepository : Repository<Activity, int>, IActivityRepository
{
    public ActivityRepository(AppDbContext context, ILogger<Repository<Activity, int>> logger) 
        : base(context, logger)
    {
    }

    protected override IQueryable<Activity> GetBaseQuery()
    {
        return base.GetBaseQuery()
            .Include(x => x.Sections);
    }
}

public interface IActivityRepository : IRepository<Activity, int>
{
    
}