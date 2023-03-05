﻿namespace LMSData.Lecturers;

public class Lecturer : DomainEntity<int>
{
    private Lecturer(int userId)
    {
        UserId = userId;
    }
    
    private Lecturer(User user)
    {
        User = user;
    }

    public int DepartmentId { get; private set; }
    public int UserId { get; private set; }
    public User User { get; private set; }
    
    private readonly List<Section> _sections = new();
    public IEnumerable<Section> Sections => _sections.AsReadOnly();
    
    public static Lecturer Create(int userId)
        => new Lecturer(userId);

    public static Lecturer Create(User user)
        => new Lecturer(user);

    public Lecturer BelongsTo(int departmentId)
    {
        DepartmentId = departmentId;
        return this;
    }
}