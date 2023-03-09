namespace LMSData.Departments;

[Repository]
public class DepartmentRepository : Repository<Department, int>, IDepartmentRepository
{
    public DepartmentRepository(AppDbContext context, ILogger<Repository<Department, int>> logger) : base(context, logger)
    {
    }

    public async Task<bool> Exists(string code)
    {
        return await GetBaseQuery().AnyAsync(x => x.Code == code);
    }
}

public interface IDepartmentRepository : IRepository<Department, int>
{
    Task<bool> Exists(string code);
}