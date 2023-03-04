namespace LMSData.Lectures;

public class Lecture : DomainEntity<int>
{
    private Lecture(string topic, int courseId)
    {
        Topic = topic;
        CourseId = courseId;
    }

    public int RoomId { get; private set; }
    public int LecturerId { get; private set; }
    public int CourseId { get; private set; }
    public string? Topic { get; private set; }
    public DateTime? Time { get; private set; }
    public Room? Room { get; private set; }
    public Lecturer? Lecturer { get; private set; }
    public Course? Course { get; private set; }
    
    private readonly List<Schedule> _schedules = new();
    public IEnumerable<Schedule> Schedules => _schedules.AsReadOnly();
    
    public static Lecture Create(string topic, int courseId)
        => new Lecture(topic, courseId);
    
    public Lecture ToBeTaughtBy(int lecturerId)
    {
        LecturerId = lecturerId;
        return this;
    }

    public Lecture ToBeHeldAt(int roomId)
    {
        RoomId = roomId;
        return this;
    }

    public Lecture On(string topic)
    {
        Topic = topic;
        return this;
    }
    
    public Lecture For(int courseId)
    {
        CourseId = courseId;
        return this;
    }
}