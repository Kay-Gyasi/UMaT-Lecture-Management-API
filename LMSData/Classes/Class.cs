namespace LMSData.Classes;

public class Class : DomainEntity<int>
{
    private Class(string name)
    {
        Name = name;
    }
    
    public int DepartmentId { get; private set; }
    public int? ScheduleId { get; private set; }
    public string Name { get; private set; }
    public bool IsLab { get; private set; }
    public Department? Department { get; private set; }
    public Schedule? Schedule { get; private set; }

    public static Class Create(string name) 
        => new Class(name);

    public Class HasSchedule(int scheduleId)
    {
        ScheduleId = scheduleId;
        return this;
    }

    public Class IsIn(int departmentId)
    {
        DepartmentId = departmentId;
        return this;
    }

    public Class AsLab()
    {
        IsLab = true;
        return this;
    }
}