using JobBoard.API;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureServices(builder.Configuration).ConfigurePipeline();

app.Run();
