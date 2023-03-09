namespace LMSData.Students;

public class Student : DomainEntity<int>
{
    private Student(int? classId)
    {
        ClassId = classId;
    }

    public int UserId { get; private set; }
    public int? ClassId { get; private set; }
    public Class? Class { get; private set; }
    public User User { get; private set; }

    public static Student Create(int? classId) => new(classId);

    public Student IsInClass(int? classId)
    {
        ClassId = classId;
        return this;
    }

    public Student IsUser(int userId)
    {
        UserId = userId;
        return this;
    }
}