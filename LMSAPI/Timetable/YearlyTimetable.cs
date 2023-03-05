namespace LMSAPI.Timetable;

/// <summary>
/// A class containing two timetables for one year
/// </summary>
public class YearlyTimetable : IUniversityTimetable
{
    private SeasonalTimetable semTimetable = new();

    /// <summary>
    /// Get the end time (24-hr time) of the latest class from the two terms
    /// </summary>
    public double LatestClassTime => semTimetable.LatestClassTime;

    /// <summary>
    /// Get the start time (24-hr time) of the earliest class from the two terms
    /// </summary>
    public double EarliestClassTime => semTimetable.EarliestClassTime;

    /// <summary>
    /// Get the total time spent in between classes over the two terms
    /// </summary>
    public double TotalTimeBetweenClasses => semTimetable.TotalTimeBetweenClasses;

    /// <summary>
    /// Get the total time spent in class over the two terms
    /// </summary>
    public double TimeInClass => semTimetable.TimeInClass;

    /// <summary>
    /// Get the total number of days in class
    /// </summary>
    public int NumDaysInClass => semTimetable.NumDaysInClass;

    /// <summary>
    /// Get a list of weekdays that have classes on that day
    /// </summary>
    public HashSet<int> DaysInClass => semTimetable.DaysInClass;

    /// <summary>
    /// Return a list of time duration between classes
    /// </summary>
    public List<double> TimeBetweenClasses
    {
        get
        {
            List<double> combinedTime = new List<double>();
            combinedTime.AddRange(semTimetable.TimeBetweenClasses);
            return combinedTime;
        }
    }

    /// <summary>
    /// Adds a section to this timetable if it fits to this timetable
    /// </summary>
    /// <param name="section">The section to add</param>
    /// <returns>True if the section is added; else false</returns>
    public bool AddSection(Section section)
    {
        return AddSection(section, section.Activity.Course.Term);
    }

    public bool AddSection(Section section, Semester term)
    {
        switch (term)
        {
            case Semester.First:
                return semTimetable.AddSection(section);
            case Semester.Second:
                return semTimetable.AddSection(section);
            default:
                throw new NotImplementedException(section.Activity.Course.Term + " was not handled before! ");
        }
    }

    /// <summary>
    /// Determines whether a section exists in this timetable
    /// </summary>
    /// <param name="section">A section</param>
    /// <returns>True if it exists in this timetable, else false</returns>
    public bool Contains(Section section)
    {
        return semTimetable.Contains(section);
    }

    /// <summary>
    /// Deletes a section from this timetable
    /// </summary>
    /// <param name="section">The section to delete</param>
    /// <returns>True if it was found and deleted successfully; else false</returns>
    public bool DeleteSection(Section section)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Determines if a section can be placed in this timetable
    /// </summary>
    /// <param name="section">The section to add</param>
    /// <returns>True if the section fits in this timetable; else false</returns>
    public bool DoesSectionFit(Section section)
    {
        switch (section.Activity.Course.Term)
        {
            case Semester.First:
                return semTimetable.DoesSectionFit(section);
            case Semester.Second:
                return semTimetable.DoesSectionFit(section);
            default:
                throw new NotImplementedException(section.Activity.Course.Term + " was not handled before! ");
        }
    }

    /// <summary>
    /// Get all the semester sections
    /// </summary>
    /// <returns>Semester sections</returns>
    public List<Section> GetSemesterSections()
    {
        return semTimetable.GetSections().ToList();
    }

    /// <summary>
    /// Get a list of sections that exist in this timetable
    /// </summary>
    /// <returns></returns>
    public List<Section> GetSections()
    {
        List<Section> combinedSections = new List<Section>();
        combinedSections.AddRange(GetSemesterSections());
        return combinedSections;
    }

    /// <summary>
    /// Make a hardcopy of this timetable
    /// </summary>
    /// <returns>A hard copy of this timetable</returns>
    public ITimetable MakeCopy()
    {
        YearlyTimetable copy = new YearlyTimetable();
        copy.semTimetable = (SeasonalTimetable) semTimetable.MakeCopy();
        return copy;
    }

    public void Show()
    {
        semTimetable.Show();
    }
}