namespace LMSData.Classes;

[Repository]
public class ClassRepository : Repository<Class, int>, IClassRepository
{
    public ClassRepository(AppDbContext context, ILogger<Repository<Class, int>> logger) : base(context, logger)
    {
    }

    protected override IQueryable<Class> GetBaseQuery()
    {
        return base.GetBaseQuery()
            .Include(x => x.Department)
            .Include(x => x.Courses);
    }
}

public interface IClassRepository : IRepository<Class, int> { }