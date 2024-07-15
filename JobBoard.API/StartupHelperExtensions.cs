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
        builder
            .Services.AddControllers(options =>
            {
                options.ReturnHttpNotAcceptable = true;
            })
            .AddNewtonsoftJson()
            .AddXmlDataContractSerializerFormatters();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        builder.Services.AddScoped<IJobOpeningRepository, JobOpeningRepository>();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseAuthorization();
        app.MapControllers();
        return app;
    }
}
