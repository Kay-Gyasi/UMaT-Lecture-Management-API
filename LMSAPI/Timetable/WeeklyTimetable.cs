using LMSAPI.Timetable.Data_Structures;

namespace LMSAPI.Timetable;

/// <summary>
/// A class used to represent a weekly schedule.
/// </summary>
public class WeeklyTimetable : ITimetable
{
    private readonly RedBlackTree<Session> _collection = new();
    private readonly List<Section> _sections = new();

    /// <summary>
    /// Constructs a new Weekly Timetable
    /// </summary>
    public WeeklyTimetable()
    {
    }

    /// <summary>
    /// Add a section in this timetable if it fits
    /// </summary>
    /// <param name="section">A section</param>
    /// <returns>True if the section fits and has been added to the timetable; else false</returns>
    public bool AddSection(Section section)
    {
        // Check if it can fit
        if (!DoesSectionFit(section))
            return false;

        foreach (Session session in section.Sessions)
            _collection.Add(session);

        _sections.Add(section);
        return true;
    }

    /// <summary>
    /// Determines if a section is in this seasonal timetable
    /// </summary>
    /// <param name="section">A section</param>
    /// <returns>True if the section is in this seasonal timetable; else false</returns>
    public bool Contains(Section section)
    {
        return _sections.Contains(section);
    }

    /// <summary>
    /// Finds and deletes the desired section from this timetable
    /// </summary>
    /// <param name="section">The section to delete</param>
    /// <returns>Returns true if the section was found and deleted; else false</returns>
    public bool DeleteSection(Section section)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Display the timetable in the console
    /// </summary>
    public void Show()
    {
        _collection.Show();
    }

    /// <summary>
    /// Determines if a section fits in this timetable
    /// </summary>
    /// <param name="section">A section</param>
    /// <returns>True if it fits; else false</returns>
    public bool DoesSectionFit(Section section)
    {
        foreach (Session session in section.Sessions)
        {
            if (!_collection.CanAdd(session))
                return false;
        }
        return true;
    }

    /// <summary>
    /// Returns the sections that exist in this timetable
    /// </summary>
    /// <returns>The sections in this timetable</returns>
    public List<Section> GetSections()
    {
        return _sections;
    }

    /// <summary>
    /// Make a deep-copy of this timetable
    /// </summary>
    /// <returns></returns>
    public ITimetable MakeCopy()
    {
        SeasonalTimetable copy = new SeasonalTimetable();
        foreach (Section section in _sections)
            copy.AddSection(section);
        return copy;
    }
}