namespace LMSAPI.Timetable.Generator;

/// <summary>
/// An interface to be implemented in all timetable generator algorithms
/// </summary>
public interface IScheduler<T> where T : IUniversityTimetable
{
    /// <summary>
    /// Generates the timetables
    /// </summary>
    /// <returns>A list of generated timetables</returns>
    List<T> GetTimetables();
}

public interface IUniversityTimetable : ITimetable
{
    double LatestClassTime { get; }
    double EarliestClassTime { get; }
    double TotalTimeBetweenClasses { get; }
    double TimeInClass { get; }
    int NumDaysInClass { get; }
    HashSet<int> DaysInClass { get; }
    List<double> TimeBetweenClasses { get; }
}

public interface ITimetable
{
    bool AddSection(Section section);
    bool Contains(Section section);
    bool DeleteSection(Section section);
    bool DoesSectionFit(Section section);
    List<Section> GetSections();
    ITimetable MakeCopy();
}
