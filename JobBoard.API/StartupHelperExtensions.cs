using JobBoard.API.Services;
using Microsoft.EntityFrameworkCore;

namespace JobBoard.API;

internal static class StartupHelperExtensions
{
    internal static WebApplication ConfigureServices(
        this WebApplicationBuilder builder,
        IConfiguration configuration
    )
    {
        builder.Services.AddControllers();
        builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        builder.Services.AddScoped<IJobOpeningRepository, JobOpeningRepository>();

        builder.Services.AddDbContext<JobBoardContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("JobBoardContext"));
        });

        return builder.Build();
    }

    internal static WebApplication ConfigurePipeline(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}
