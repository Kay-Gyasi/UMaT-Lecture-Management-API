namespace LMSData.CourseSections;

[Repository]
public class SectionRepository : Repository<Section, int>, ISectionRepository
{
    public SectionRepository(AppDbContext context, ILogger<Repository<Section, int>> logger) 
        : base(context, logger)
    {
    }

    protected override IQueryable<Section> GetBaseQuery()
    {
        return base.GetBaseQuery()
            .Include(x => x.Sessions);
    }
}

public interface ISectionRepository : IRepository<Section, int> { }