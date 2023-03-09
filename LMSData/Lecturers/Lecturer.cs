namespace LMSData.Lecturers;

public class Lecturer : DomainEntity<int>
{
    private Lecturer(int userId)
    {
        UserId = userId;
    }
    
    private Lecturer(User user)
    {
        User = user;
    }

    public int? DepartmentId { get; private set; }
    public int UserId { get; private set; }
    public User User { get; private set; }
    
    private readonly List<Course> _courses = new();
    public IEnumerable<Course> Courses => _courses.AsReadOnly();
    
    public static Lecturer Create(int userId)
        => new Lecturer(userId);

    public static Lecturer Create(User user)
        => new Lecturer(user);

    public Lecturer BelongsTo(int? departmentId)
    {
        DepartmentId = departmentId;
        return this;
    }

    public Lecturer IsUser(User? user)
    {
        User = user;
        return this;
    }
}