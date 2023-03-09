namespace LMSData.Students;

[Repository]
public class StudentRepository : Repository<Student, int>, IStudentRepository
{
    public StudentRepository(AppDbContext context, ILogger<Repository<Student, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface IStudentRepository : IRepository<Student, int> {}