using LMSAPI.Timetable.Generator.GeneticScheduler;
using LMSData.Classes;

namespace LMSAPI.Timetable;

public class TimetablesController : Controller
{
    private readonly TimeTableProcessor _processor;

    public TimetablesController(TimeTableProcessor processor)
    {
        _processor = processor;
    }

    [HttpPost]
    public async Task<IActionResult> GetTimetables([FromBody] TimetableRequest request)
    {
        var result = await _processor.GetTimetables(request);
        return Created(nameof(GetTimetables), result);
    }
}

[Processor]
public class TimeTableProcessor
{
    private readonly IClassRepository _classRepository;

    public TimeTableProcessor(IClassRepository classRepository)
    {
        _classRepository = classRepository;
    }
    
    public async Task<List<SimplifiedYearlyTimetable>?> GetTimetables(TimetableRequest request)
    {
        if (request.ClassId <= 0 || request.DepartmentId <= 0)
            return null;

        if (request.Preferences == null || request.Restrictions == null)
            return null;
        
        // Get the courses from the database
        var activities = new List<Activity>();
        var classTo = await _classRepository.FindByIdAsync(request.ClassId);
        foreach (var course in classTo!.Courses.Where(x => x.Term == request.Semester))
        {
            activities.AddRange(course.Activities);
        }
        
        // Generate the timetables            
        var scorer = new TimetableScorer(request.Restrictions, request.Preferences);
        var generator = new GeneticScheduler<YearlyTimetable>(activities, scorer, request.Preferences, request.Restrictions)
        {
            NumGenerations = 100,
            PopulationSize = 16,
            MutationRate = 0.1,
            CrossoverRate = 0.6
        };
        var timetables = generator.GetTimetables();    
        
        // Convert the timetables to mini timetables (which will be presented to the user)
        List<SimplifiedYearlyTimetable> miniTimetables = new();
        
        for (var i = 0; i < timetables.Count; i++)
            miniTimetables.Add(new SimplifiedYearlyTimetable(timetables[i], "Timetable #" + (i + 1)));                

        return miniTimetables;
    }
}