namespace LMSData.Semesters;

[Repository]
public class SemesterRepository : Repository<Semester, int>, ISemesterRepository
{
    public SemesterRepository(AppDbContext context, ILogger<Repository<Semester, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface ISemesterRepository : IRepository<Semester, int>{}