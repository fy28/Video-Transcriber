using VideoTranscriber.Application;
using VideoTranscriber.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

const string AngularDevelopmentCorsPolicy = "AngularDevelopment";

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy(AngularDevelopmentCorsPolicy, policy =>
    {
        policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseCors(AngularDevelopmentCorsPolicy);
}

app.UseHttpsRedirection();

app.MapGet("/api/health", () =>
{
    return Results.Ok(new { status = "healthy" });
})
.WithName("GetHealth")
.WithTags("Health");

app.Run();
