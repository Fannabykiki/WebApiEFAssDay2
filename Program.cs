using Microsoft.EntityFrameworkCore;
using StudentManagement.Repositories;
using WebApiEFAssDay1.Models;
using WebApiEFAssDay1.Repositories.Interface;
using WebApiEFAssDay1.Services;
using WebApiEFAssDay1.Services.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
// Add services to the container.
builder.Services.AddDbContext<StudentContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnString")));
builder.Services.AddControllers();
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
