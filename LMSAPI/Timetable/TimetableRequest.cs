namespace LMSAPI.Timetable;

public class TimetableRequest
{
    public int DepartmentId { get; set; }
    public int ClassId { get; set; }
    public Semester Semester { get; set; }
    public Preferences? Preferences { get; set; }
    public Restrictions? Restrictions { get; set; }
}