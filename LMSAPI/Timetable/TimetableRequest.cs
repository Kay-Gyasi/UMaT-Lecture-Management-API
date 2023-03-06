namespace LMSAPI.Timetable;

public class TimetableRequest
{
    public int DepartmentId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    public Preferences? Preferences { get; set; }
    public Restrictions? Restrictions { get; set; }
}