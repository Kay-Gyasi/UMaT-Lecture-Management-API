using LMSData.Helpers;

namespace LMSData.Schedules;

public class ScheduleConfiguration : DatabaseConfiguration<Schedule, int>
{
    public override void Configure(EntityTypeBuilder<Schedule> builder)
    {
        base.Configure(builder);
        builder.ToTable(DomainEntities.Schedule);
    }
}