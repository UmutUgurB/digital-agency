
using digitalAgency.Persistence.Extensions;
using digitalAgency.Application.Extensions;
using digitalAgency.WebApi.Middlewares;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Serilog Configuration
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(
        path: "Logs/log-.txt",
        rollingInterval: RollingInterval.Day,
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
    )
    .CreateLogger();

builder.Host.UseSerilog();

Log.Information("🚀 Digital Agency API Starting up...");

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins(
            "http://localhost:3000",      
            "https://yourdomain.com"      
        )
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .WithExposedHeaders("Location"); 
    });
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistenceExtensions(builder.Configuration);
builder.Services.AddApplicationExtensions();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Configure the HTTP request pipeline.

// Global Exception Handling Middleware (EN ÜSTTE OLMALI!)
app.UseExceptionHandlingMiddleware();

app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthorization();

// Request logging
app.UseSerilogRequestLogging();

app.MapControllers();

try
{
    Log.Information("✅ Digital Agency API started successfully");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "❌ Application startup failed");
}
finally
{
    Log.CloseAndFlush();
}
