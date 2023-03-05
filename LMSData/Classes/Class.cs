﻿namespace LMSData.Classes;

public class Class : DomainEntity<int>
{
    private Class(Level level, int departmentId)
    {
        Level = level;
        DepartmentId = departmentId;
    }
    
    public int DepartmentId { get; private set; }
    public Level Level { get; set; }
    public Department? Department { get; private set; }
    
    private readonly List<Course> _courses = new();
    public IEnumerable<Course> Courses => _courses.AsReadOnly();


    public static Class Create(Level level, int departmentId) 
        => new Class(level, departmentId);
}

public enum Level
{
    One = 100,
    Two = 200,
    Three = 300,
    Four = 400
}