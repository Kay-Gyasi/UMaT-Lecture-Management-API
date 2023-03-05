namespace LMSData.Activities;

public class Activity : DomainEntity<int>
{
    private Activity() { }
    private Activity(int courseId, ActivityType type)
    {
        CourseId = courseId;
        ActivityType = type;
    }

    public int CourseId { get; private set; }
    public Course Course { get; private set; }

    public ActivityType ActivityType { get; private set; }
    
    private readonly List<Section> _sections = new();
    public IEnumerable<Section> Sections => _sections.AsReadOnly();

    public static Activity Create(int courseId, ActivityType type) => new Activity(courseId, type);

    public Activity ForCourse(int courseId)
    {
        CourseId = courseId;
        return this;
    }

    public Activity OfType(ActivityType type)
    {
        ActivityType = type;
        return this;
    }
}

public enum ActivityType
{
    Lecture = 1,
    Practical,
    LabWork
}
