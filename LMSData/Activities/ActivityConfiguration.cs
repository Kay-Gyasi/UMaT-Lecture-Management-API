namespace LMSData.Activities;

public class ActivityConfiguration : DatabaseConfiguration<Activity, int>
{
    public override void Configure(EntityTypeBuilder<Activity> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.ActivityType)
            .HasConversion(new EnumToStringConverter<ActivityType>());
    }
}