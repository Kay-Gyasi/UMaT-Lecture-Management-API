namespace LMSAPI.Timetable.Generator;

public class Preferences
{
    /// <summary>
    /// Get / set the class type for the two terms
    /// </summary>
    public Day ClassType { get; set; }

    /// <summary>
    /// Get / set the number of days in class for the two terms
    /// </summary>
    public Quantity NumDaysInClass { get; set; }

    /// <summary>
    /// Get / set the time between classes for the two terms
    /// </summary>
    public Quantity TimeBetweenClasses { get; set; }

    /// <summary>
    /// Get / set the amount of time spent for lunch (in minutes)
    /// </summary>
    public double? LunchPeriod { get; set; } = 30;

    public bool AvoidLongSessions { get; set; }
}

public enum Day
{
    Undefined,
    Morning,
    Afternoon,
    Evening,
    Night
}

public enum Quantity
{
    Undefined,
    Minimum,
    Maximum
}