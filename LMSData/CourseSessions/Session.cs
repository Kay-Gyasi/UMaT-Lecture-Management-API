namespace LMSData.CourseSessions;

public class Session : DomainEntity<int>, IComparable
{
    private Session(int sectionId, int roomId)
    {
        SectionId = sectionId;
        RoomId = roomId;
    }

    public int SectionId { get; private set; }
    public Section Section { get; private set; }

    public int RoomId { get; private set; }
    public Room Room { get; private set; }
    
    /// <summary>
    /// Get the compressed start time of this session 
    /// (this includes the weekday and 24-hr start time)
    /// </summary>
    public double StartTimeWithWeekday { get; private set; }

    /// <summary>
    /// Get the compressed end time of this session 
    /// (this includes the weekday and 24-hr end time)
    /// </summary>
    public double EndTimeWithWeekday { get; private set; }

    /// <summary>
    /// Get the 24-hr start time of this session
    /// </summary>
    /// <returns></returns>
    public double StartTime
    {
        get { return StartTimeWithWeekday % 100; }
    }

    /// <summary>
    /// Get the 24-hr end time of this session
    /// </summary>
    /// <returns></returns>
    public double EndTime
    {
        get { return EndTimeWithWeekday % 100; }
    }

    /// <summary>
    /// Get the weekday which this session starts on
    /// </summary>
    /// <returns></returns>
    public int StartDay
    {
        get { return ((int)StartTimeWithWeekday) / 100; }
    }

    /// <summary>
    /// Get the weekday which this session ends on
    /// </summary>
    /// <returns></returns>
    public int EndDay
    {
        get { return ((int)EndTimeWithWeekday) / 100; }
    }

    /// <summary>
    /// Returns -1 if this object is before <paramref name="obj"/>.
    /// Returns 1 if this object comes after <paramref name="obj"/>
    /// Returns 0 if this object intersects with <paramref name="obj"/>
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public int CompareTo(object obj)
    {
        if (!(obj is Session))
            return 0;

        else
        {
            Session otherSession = (Session)obj;
            if (EndTimeWithWeekday <= otherSession.StartTimeWithWeekday)
                return -1;
            else if (otherSession.EndTimeWithWeekday <= StartTimeWithWeekday)
                return 1;
            else
                return 0;
        }
    }

    public override string ToString()
    {
        return StartTimeWithWeekday + "-" + EndTimeWithWeekday;
    }

    public static Session Create(int sectionId, int roomId) => new Session(sectionId, roomId);

    public Session ForSection(int sectionId)
    {
        SectionId = sectionId;
        return this;
    }

    public Session ToBeHeldIn(int roomId)
    {
        RoomId = roomId;
        return this;
    }
    public Session SetStartTimeWithWeekday(double startTimeWithWeekday)
    {
        StartTimeWithWeekday = startTimeWithWeekday;
        return this;
    }
    
    public Session SetEndTimeWithWeekday(double endTimeWithWeekday)
    {
        EndTimeWithWeekday = endTimeWithWeekday;
        return this;
    }
}
