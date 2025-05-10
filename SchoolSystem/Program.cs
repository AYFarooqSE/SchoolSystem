using Microsoft.EntityFrameworkCore;
using SchoolSystem.APIRepositories;
using SchoolSystem.APIRepositories.V2;
using SchoolSystem.APIServices;
using SchoolSystem.APIServices.V2;
using SchoolSystem.Data;
using SchoolSystem.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Adding Connection String Name
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(
    builder.Configuration.GetConnectionString("ConnectionStr")
    ));

builder.Services.AddScoped<ITeacherServicev2, TeacherRepositoryv2>();
builder.Services.AddScoped<IStudentService, StudentService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
