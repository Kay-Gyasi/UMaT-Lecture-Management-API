namespace LMSData.Activities;

public class Activity : DomainEntity<int>
{
    public Activity()
    {
    }

    public int CourseId { get; set; }
    public Course Course { get; set; }

    public ActivityType ActivityType { get; set; }
    
    private readonly List<Section> _sections = new();
    public IEnumerable<Section> Sections => _sections.AsReadOnly();
}

public enum ActivityType
{
    Lecture = 1,
    Practical,
    LabWork
}
