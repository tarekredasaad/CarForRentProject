using WebApplication1.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Data.Repository;
using WebApplication1.Models;
using Services;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder => builder
            .WithOrigins("http://localhost:4200")
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
    .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll)
            .LogTo(log => Debug.WriteLine(log), LogLevel.Information)
           .EnableSensitiveDataLogging()
           ; 
});
builder.Services.AddScoped<IRepository<Car>, Repository<Car>>();
builder.Services.AddScoped<IRepository<Model>, Repository<Model>>();
builder.Services.AddScoped<IRepository<Order>, Repository<Order>>();
builder.Services.AddScoped<CarServices>();
builder.Services.AddScoped<OrderServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();
