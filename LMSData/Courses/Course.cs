namespace LMSData.Courses;

public class Course : DomainEntity<int>
{
    private Course(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public int LecturerId { get; private set; }
    public int DepartmentId { get; private set; }
    public int CreditHours { get; private set; }
    public int NoOfHoursPerWeek { get; private set; }
    public int NoOfHoursForLabWorkPerWeek { get; private set; }
    public int NoOfHoursForOnlineLecturePerWeek { get; private set; }
    public string Name { get; private set; }
    public string Code { get; private set; }
    public string? Description { get; private set; }
    public bool LabWorkIncluded { get; private set; }
    public bool OnlineLectureIncluded { get; private set; }
    public Lecturer? Lecturer { get; private set; }
    public Department? Department { get; private set; }
    
    private readonly List<Lecture> _lectures = new();
    public IEnumerable<Lecture> Lectures => _lectures.AsReadOnly();

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

    public Course WithDescription(string desc)
    {
        Description = desc;
        return this;
    }

    public Course IsTaughtBy(int lecturerId)
    {
        LecturerId = lecturerId;
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

    public Course HasCreditHours(int creditHours)
    {
        CreditHours = creditHours;
        return this;
    }

    /// <summary>
    /// Number of hours to be taught in a week
    /// </summary>
    /// <param name="noOfHoursPerWeek"></param>
    /// <returns></returns>
    public Course ToBeTaughtFor(int noOfHoursPerWeek)
    {
        NoOfHoursPerWeek = noOfHoursPerWeek;
        return this;
    }

    /// <summary>
    /// Indicates if course has a part to be taken in the lab
    /// </summary>
    /// <param name="noOfHours">No. of hours a week for lab work</param>
    /// <returns></returns>
    public Course HasLabWork(int noOfHours = 1)
    {
        LabWorkIncluded = true;
        NoOfHoursForLabWorkPerWeek = noOfHours;
        return this;
    }
    
    /// <summary>
    /// Indicates if course has online lectures
    /// </summary>
    /// <param name="noOfHours">No. of hours a week for online lectures</param>
    /// <returns></returns>
    public Course HasOnlineLectures(int noOfHours = 1)
    {
        OnlineLectureIncluded = true;
        NoOfHoursForOnlineLecturePerWeek = noOfHours;
        return this;
    }
}