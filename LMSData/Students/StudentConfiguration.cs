namespace LMSData.Students;

public class StudentConfiguration : DatabaseConfiguration<Student, int>
{
    public override void Configure(EntityTypeBuilder<Student> builder)
    {
        base.Configure(builder);
    }
}