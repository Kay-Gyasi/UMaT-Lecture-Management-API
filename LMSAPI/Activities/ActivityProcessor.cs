namespace LMSAPI.Activities;

public record ActivityCommand(int Id, int CourseId, ActivityType ActivityType);

public record ActivityDto(int Id, int CourseId, ActivityType ActivityType,
    CourseDto Course, IEnumerable<SectionDto> Sections);

public record ActivityPageDto(int Id, int CourseId, ActivityType ActivityType,
    CoursePageDto Course);

[Processor]
public class ActivityProcessor
{
    private readonly IActivityRepository _activityRepository;

    public ActivityProcessor(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }
    
    public async Task<int> UpsertAsync(ActivityCommand command)
    {
        var isNew = command.Id == 0;
        Activity? activity;

        if (isNew)
        {
            activity = Activity.Create(command.CourseId, command.ActivityType);
            await _activityRepository.AddAsync(activity);
            return activity.Id;
        }

        activity = await _activityRepository.FindByIdAsync(command.Id);
        if(activity is null) throw new NullReferenceException();

        activity.ForCourse(command.CourseId)
            .OfType(command.ActivityType);
        await _activityRepository.UpdateAsync(activity);
        return activity.Id;
    }

    public async Task<ActivityDto> GetAsync(int id)
    {
        var activity = await _activityRepository.FindByIdAsync(id);
        if (activity is null) throw new NullReferenceException();

        return activity.Adapt<ActivityDto>();
    }

    public async Task<PaginatedList<ActivityPageDto>> GetPageAsync(PaginatedCommand command)
    {
        var page = await _activityRepository.GetPageAsync(command);
        return page.Adapt<PaginatedList<ActivityPageDto>>();
    }

    public async Task DeleteAsync(int id)
    {
        var activity = await _activityRepository.FindByIdAsync(id);
        if (activity is null) throw new NullReferenceException();

        await _activityRepository.SoftDeleteAsync(activity);
    }
    
    public async Task HardDeleteAsync(int id)
    {
        var activity = await _activityRepository.FindByIdAsync(id);
        if (activity is null) throw new NullReferenceException();

        await _activityRepository.DeleteAsync(activity);
    }
}