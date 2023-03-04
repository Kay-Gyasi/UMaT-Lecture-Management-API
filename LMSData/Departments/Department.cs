namespace LMSData.Departments;

public class Department : DomainEntity<int>
{
    private Department(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
    
    private readonly List<Lecturer> _lecturers = new();
    public IEnumerable<Lecturer> Lectures => _lecturers.AsReadOnly();
    
    private readonly List<Course> _courses = new();
    public IEnumerable<Course> Courses => _courses.AsReadOnly();

    private readonly List<Class> _classes = new();
    public IEnumerable<Class> Classes => _classes.AsReadOnly();

    public static Department Create(string name) 
        => new Department(name);

    public Department HasName(string name)
    {
        Name = name;
        return this;
    }
}