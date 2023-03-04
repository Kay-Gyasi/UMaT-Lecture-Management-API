namespace LMSData.Courses;

[Repository]
public class CourseRepository : Repository<Course, int>, ICourseRepository
{
    public CourseRepository(AppDbContext context, ILogger<Repository<Course, int>> logger) : base(context, logger)
    {
    }
}

public interface ICourseRepository : IRepository<Course, int> { }