using LMSData.Exceptions;

namespace LMSData;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.RegisterDbContext(configuration)
            .RegisterRepositories();
        return services;
    }

    private static IServiceCollection RegisterDbContext(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Default"));
            //options.EnableSensitiveDataLogging();
        });

        services.AddIdentityCore<User>()
            .AddRoles<IdentityRole<int>>()
            .AddEntityFrameworkStores<AppDbContext>();
        return services;
    }

    private static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        var types = typeof(AppDbContext).Assembly
            .DefinedTypes;
        var repositories = types.Where(x => x.IsClass && x.CustomAttributes
            .Any(a => a.AttributeType == typeof(RepositoryAttribute)));

        try
        {
            foreach (var repository in repositories)
            {
                var iRepository = repository.GetInterfaces()
                                      .FirstOrDefault(i => i.Name == $"I{repository.Name}") 
                                  ?? throw new RepositoryNotFoundException(
                                      $"{repository.Name} has no interface with name I{repository.Name}");
                services.AddScoped(iRepository, repository);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return services;
    } 
}