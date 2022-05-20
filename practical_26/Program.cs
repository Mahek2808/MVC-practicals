using practical_26.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using practical_26.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<practical_26Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("practical_26Context") ?? throw new InvalidOperationException("Connection string 'practical_26Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<studentContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));

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
