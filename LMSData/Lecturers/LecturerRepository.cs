namespace LMSData.Lecturers;

[Repository]
public class LecturerRepository : Repository<Lecturer, int>, ILecturerRepository
{
    public LecturerRepository(AppDbContext context, ILogger<Repository<Lecturer, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface ILecturerRepository : IRepository<Lecturer, int> { }