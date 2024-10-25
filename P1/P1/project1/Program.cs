// Project 1 .NET revature training
// 10/21/2024
// Alan Espinoza

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using project1.Data;
using project1.Repository;
using project1.Repository.Interface;
using project1.Service;
using project1.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Add DB Context and service dependencies

var connectionString = builder.Configuration["ConnectionStrings:p1AzureCloudConnectionString0"];

builder.Services.AddDbContext<Project1Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IUserRepository, UserRepository>();

//var apiCorsPolicy = "ApiCorsPolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "ApiCorsPolicy",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000",
                           "http://10.0.0.250:3000",
                           "https://localhost:3000",
                           "https://10.0.0.250:3000",
                           "10.0.0.250:300",
                           "localhost:3000")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                      });
});

builder.Services.AddControllers();


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
app.UseCors();
app.MapControllers();
app.Run();