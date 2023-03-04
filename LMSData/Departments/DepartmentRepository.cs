namespace LMSData.Departments;

[Repository]
public class DepartmentRepository : Repository<Department, int>, IDepartmentRepository
{
    public DepartmentRepository(AppDbContext context, ILogger<Repository<Department, int>> logger) : base(context, logger)
    {
    }
}

public interface IDepartmentRepository : IRepository<Department, int> { }