using LMSAPI.Helpers;
using Microsoft.OpenApi.Models;

namespace LMSAPI;

public static class DependencyInjection
{
    public static void RegisterServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.InstallDefaults()
            .InstallSwagger()
            .InstallProcessors()
            .AddPersistence(configuration)
            .AddAuthenticationService(configuration)
            .AddScoped<ExcelReader>();
    }

    private static IServiceCollection InstallDefaults(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        return services;
    }

    private static IServiceCollection InstallSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "UMaT Lecture Management API",
                Contact = new OpenApiContact
                {
                    Email = "kofigyasidev@gmail.com",
                    Name = "Kofi Gyasi",
                    Url = new Uri("https://kaygyasi.vercel.app")
                },
                Description = "An API for managing lectures at UMaT."
            });
            
            options.CustomOperationIds(description => 
                description.TryGetMethodInfo(out var methodInfo) 
                    ? methodInfo.Name : description.RelativePath);
            
            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "JWT Authorization using the bearer scheme",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {new OpenApiSecurityScheme{Reference = new OpenApiReference()
                {
                    Id = "Bearer",
                    Type = ReferenceType.SecurityScheme
                }}, new List<string>()}
            });
            
            // var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            // options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });
        return services;
    }

    private static IServiceCollection InstallProcessors(this IServiceCollection services)
    {
        var processors = typeof(ProcessorAttribute).Assembly.DefinedTypes
            .Where(x => x.CustomAttributes.Any(a => 
                a.AttributeType == typeof(ProcessorAttribute)));
        
        foreach (var processor in processors)
        {
            services.AddScoped(processor);
        }
        return services;
    }
}