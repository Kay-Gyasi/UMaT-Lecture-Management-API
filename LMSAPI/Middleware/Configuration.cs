using Microsoft.EntityFrameworkCore;
using ILogger = Serilog.ILogger;

namespace LMSAPI.Middleware;

public static class Configuration
{
    public static WebApplication BuildApp(this WebApplicationBuilder builder, ILogger logger)
    {
        builder.Host.UseSerilog(logger);
        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(logger); 
        return builder.Build();
    }
    
    public static void ConfigurePipeline(this WebApplication app)
    {
        app.RunMigrations();
        app.UseSwagger();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                //options.DisplayOperationId();
            });
        }
        
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = string.Empty;
        });
        
        app.UseHttpsRedirection();

        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
    
    private static void RunMigrations(this WebApplication app)
    {
        if (Environment.CommandLine.Contains("migrations add")) return;
        using var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
        context?.Database.Migrate();
    }
}