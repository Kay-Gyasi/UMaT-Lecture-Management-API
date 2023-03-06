using LMSData.Semesters;

namespace LMSData.Courses;

public class Course : DomainEntity<int>
{
    private Course(string name, string code)
    {
        Name = name;
        Code = code;
    }

    /// <summary>
    /// The department that owns this course
    /// </summary>
    public int DepartmentId { get; private set; }
    public int SemesterId { get; private set; }
    public int CreditHours { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public string? Description { get; private set; }
    public Department? Department { get; private set; }
    public Semester? Semester { get; private set; }
    
    private readonly List<Activity> _activities = new();
    public IEnumerable<Activity> Activities => _activities.AsReadOnly();
    
    private readonly List<Class> _classes = new();
    public IEnumerable<Class> Classes => _classes.AsReadOnly();


    public static Course Create(string name, string code) 
        => new Course(name, code);

    public Course WithName(string name)
    {
        Name = name;
        return this;
    }

    public Course WithCode(string code)
    {
        Code = code;
        return this;
    }

    public Course WithDescription(string? desc)
    {
        Description = desc;
        return this;
    }

    /// <summary>
    /// Department to which course belongs
    /// </summary>
    /// <param name="departmentId"></param>
    /// <returns></returns>
    public Course BelongsTo(int departmentId)
    {
        DepartmentId = departmentId;
        return this;
    }

    public Course ForSemester(int semesterId)
    {
        SemesterId = semesterId;
        return this;
    }

    public Course HasCreditHours(int creditHours)
    {
        CreditHours = creditHours;
        return this;
    }
}