namespace LMSData.Lectures;

[Repository]
public class LectureRepository : Repository<Lecture, int>, ILectureRepository
{
    public LectureRepository(AppDbContext context, ILogger<Repository<Lecture, int>> logger) 
        : base(context, logger)
    {
    }
}

public interface ILectureRepository : IRepository<Lecture, int> { }