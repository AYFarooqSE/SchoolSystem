using Microsoft.EntityFrameworkCore;
using SchoolSystem.APIRepositories;
using SchoolSystem.APIRepositories.V2;
using SchoolSystem.APIServices;
using SchoolSystem.APIServices.V2;
using SchoolSystem.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using SchoolSystem.Validators;
using SchoolSystem.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

//builder.Services.AddScoped < IValidator<TeachersModel>, TeachersModelValidator > ();

// Adding Connection String Name
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(
    builder.Configuration.GetConnectionString("ConnectionStr")
    ));

builder.Services.AddScoped<ITeacherServicev2, TeacherRepositoryv2>();

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
