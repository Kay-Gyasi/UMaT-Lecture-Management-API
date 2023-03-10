using LMSData.Helpers;

namespace LMSData.Lecturers;

public class LecturerConfiguration : DatabaseConfiguration<Lecturer, int>
{
    public override void Configure(EntityTypeBuilder<Lecturer> builder)
    {
        base.Configure(builder);
        builder.ToTable(DomainEntities.Lecturer);
    }
}