namespace LMSAPI.Timetable;

/// <summary>
/// A class used to represent a year's timetable (Fall and Winter timetables)
/// </summary>
public class SimplifiedYearlyTimetable
{
    /// <summary>
    /// Constructs a SimplifiedYearlyTimetable
    /// </summary>
    /// <param name="existingTimetable">The existing yearly timetable</param>
    /// <param name="name">The name of this timetable</param>
    public SimplifiedYearlyTimetable(YearlyTimetable existingTimetable, string name)
    {
        Name = name;
        TotalTimeBetweenClasses = existingTimetable.TotalTimeBetweenClasses;
        TotalTimeInClass = existingTimetable.TimeInClass;

        // Populating fall-timetable blocks
        foreach (Section section in existingTimetable.GetSemesterSections())
        foreach (Session session in section.Sessions)
        {
            var term = session.Section.Activity.Course.Term;
            SimplifiedTimetableBlock block = new SimplifiedTimetableBlock(session, term);
            SemesterTimetableBlocks.Add(block);
        }
    }

    /// <summary>
    /// Get / set the name of this timetable
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Get / set the timetable blocks in the semester
    /// </summary>
    public List<SimplifiedTimetableBlock> SemesterTimetableBlocks = new();
    
    /// <summary>
    /// Get / set the total amount of time spent in class in both the fall and winter terms
    /// </summary>
    public double TotalTimeInClass { get; set; }

    /// <summary>
    /// Get / set the total amount of time spent between classes in both the fall and winter terms
    /// </summary>
    public double TotalTimeBetweenClasses { get; set; }
}