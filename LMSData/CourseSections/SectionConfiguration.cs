namespace LMSData.CourseSections;

public class SectionConfiguration : DatabaseConfiguration<Section, int>
{
    public override void Configure(EntityTypeBuilder<Section> builder)
    {
        base.Configure(builder);
        builder.Property(x => x.Type)
            .HasConversion(new EnumToStringConverter<SectionType>());
    }
}