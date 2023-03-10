using LMSData.Helpers;

namespace LMSData.Departments;

public class DepartmentConfiguration : DatabaseConfiguration<Department, int>
{
    public override void Configure(EntityTypeBuilder<Department> builder)
    {
        base.Configure(builder);
        builder.ToTable(DomainEntities.Department);
    }
}