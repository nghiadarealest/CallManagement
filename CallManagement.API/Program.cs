using CallManagement.Application.Usecases;
using CallManagement.Domain.Interfaces;
using CallManagement.Infrastructure.Persistence;
using CallManagement.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// Database
builder.Services.AddDbContext<CallDbContext>(options =>
    options.UseSqlite("Data Source=call.db")); 
// DI – Dependency Injection
builder.Services.AddScoped<ICallRepository, SqliteCallRepository>();

// Usecases
builder.Services.AddScoped<CreateCallUseCase>();
builder.Services.AddScoped<GetCallsByDateUseCase>();
builder.Services.AddScoped<GetCallStatsUseCase>();
builder.Services.AddScoped<IVoiceAnalyzer, MockVoiceAnalyzer>();

var app = builder.Build();

// HTTP pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
