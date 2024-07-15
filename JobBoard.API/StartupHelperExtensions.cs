namespace JobBoard.API;

internal static class StartupHelperExtensions
{
    internal static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
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
