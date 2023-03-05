namespace LMSAPI.Timetable.Generator;

public class Restrictions
{
    private double _earliestClass = 6.0; // default value is 6:00 AM
    private double _latestClass = 18.30; // default value is 6:30 PM

    public double? EarliestClass
    {
        get => _earliestClass;
        set
        {
            if (value.HasValue && (value.Value < 0 || value.Value > 24))
            {
                throw new ArgumentOutOfRangeException("EarliestClass", "EarliestClass must be between 0 and 24.");
            }

            _earliestClass = value ?? _earliestClass;
        }
    }

    public double? LatestClass
    {
        get => _latestClass;
        set
        {
            if (value.HasValue && (value.Value < 0 || value.Value > 24))
            {
                throw new ArgumentOutOfRangeException("LatestClass", "LatestClass must be between 0 and 24.");
            }

            _latestClass = value ?? _latestClass;
        }
    }
}
