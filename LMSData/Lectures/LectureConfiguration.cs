using LMSData.Helpers;

namespace LMSData.Lectures;

public class LectureConfiguration : DatabaseConfiguration<Lecture, int>
{
    public override void Configure(EntityTypeBuilder<Lecture> builder)
    {
        base.Configure(builder);
        builder.ToTable(DomainEntities.Lecture);
    }
}