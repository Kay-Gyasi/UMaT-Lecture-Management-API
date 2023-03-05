namespace LMSData.CourseSessions;

public class Session : DomainEntity<int>, IComparable
{
    public Session()
    {
    }

    public int SectionId { get; set; }
    public Section Section { get; set; }

    public int RoomId { get; set; }
    public Room Room { get; set; }
    
    /// <summary>
    /// Get the compressed start time of this session 
    /// (this includes the weekday and 24-hr start time)
    /// </summary>
    public double StartTimeWithWeekday { get; set; }

    /// <summary>
    /// Get the compressed end time of this session 
    /// (this includes the weekday and 24-hr end time)
    /// </summary>
    public double EndTimeWithWeekday { get; set; }

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
}
