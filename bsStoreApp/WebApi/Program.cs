using Microsoft.EntityFrameworkCore;
using Repositories.EF;
using WebApi.Extensions;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

<<<<<<< HEAD
builder.Services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly).AddNewtonsoftJson();
=======
builder.Services.AddControllers().AddNewtonsoftJson();
>>>>>>> 9f3cb582deb96204747379270afb54ed57b90b9d
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ConfigureSqlContext(builder.Configuration);

builder.Services.ConfigurationRepositoryManager(); 

builder.Services.ConfigurationServiceManager();

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
