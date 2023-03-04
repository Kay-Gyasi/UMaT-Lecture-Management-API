namespace LMSData.Schedules;

public class Schedule : DomainEntity<int>
{
    private Schedule(int classId)
    {
        ClassId = classId;
    }

    public int ClassId { get; private set; }
    
    private readonly List<Lecture> _lectures = new();
    public IEnumerable<Lecture> Lectures => _lectures.AsReadOnly();
    
    public static Schedule Create(int classId)
        => new Schedule(classId);

    public Schedule AddLecture(Lecture lecture)
    {
        _lectures.Add(lecture);
        return this;
    }
    
    public Schedule For(int classId)
    {
        ClassId = classId;
        return this;
    }
}