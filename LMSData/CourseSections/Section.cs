namespace LMSData.CourseSections;

public class Section : DomainEntity<int>
{
    private Section()
    {
        Activity = null;
        Type = SectionType.Discussion;
    }

    public int ActivityId { get; private set; }
    public SectionType Type { get; private set; }
    public Activity Activity { get; private set; }
    
    private readonly List<Lecturer> _lecturers = new();
    public IEnumerable<Lecturer> Lecturers => _lecturers.AsReadOnly();
    
    private readonly List<Session> _sessions = new();
    public IEnumerable<Session> Sessions => _sessions.AsReadOnly();

    public static Section Create() => new();

    public Section OnActivity(int activityId)
    {
        ActivityId = activityId;
        return this;
    }

    public Section OfType(SectionType type)
    {
        Type = type;
        return this;
    }
    
    /// <summary>
    /// Return the earliest session's start time
    /// </summary>
    public double MaxStartTime
    {
        get
        {
            double minStartTime = 1000;
            foreach (Session session in Sessions)
            {
                if (session.StartTime < minStartTime)
                    minStartTime = session.StartTime;
            }
            return minStartTime;
        }
    }

    /// <summary>
    /// Return the latest session's start time
    /// </summary>
    public double MaxEndTime
    {
        get
        {
            double maxEndTime = 0;
            foreach (Session session in Sessions)
            {
                if (session.EndTime > maxEndTime)
                    maxEndTime = session.EndTime;
            }
            return maxEndTime;
        }
    }
}

public enum SectionType
{
    Discussion = 1,
    Practicals,
    LabWork
}