namespace LMSData;

public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public AppDbContext() { }

    public DbSet<Class> Classes { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Semester> Semesters { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Lecturer> Lecturers { get; set; }
    public DbSet<Room> Rooms { get; set; }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new())
    {
        foreach (var entry in ChangeTracker.Entries()
                     .Where(x => x.State is EntityState.Added or EntityState.Modified))
        {
            if (entry.Entity is not DomainEntity<int> entity) continue;
            entity.Audit ??= Audit.Create();
            entity.Audit.WasUpdatedBy("admin");
        }
        
        foreach (var entry in ChangeTracker.Entries()
                     .Where(x => x.State is EntityState.Deleted))
        {
            if (entry.Entity is not DomainEntity<int> entity) continue;
            entity.Audit?.WasUpdatedBy("admin");
            entity.Audit?.Delete();
        }

        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<User>()
            .Property(x => x.Type)
            .HasConversion(new EnumToStringConverter<UserType>());
        builder.Entity<User>().Property(x => x.FirstName)
            .HasColumnType("varchar")
            .HasMaxLength(50);
        builder.Entity<User>().Property(x => x.LastName)
            .HasColumnType("varchar")
            .HasMaxLength(50);
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.Development);
        }
    }
}