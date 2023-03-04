namespace LMSData.Classes;

[Repository]
public class ClassRepository : Repository<Class, int>, IClassRepository
{
    public ClassRepository(AppDbContext context, ILogger<Repository<Class, int>> logger) : base(context, logger)
    {
    }
}

public interface IClassRepository : IRepository<Class, int> { }