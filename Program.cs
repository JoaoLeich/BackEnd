using BackEnd.Services.Classes;
using BackEnd.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ILivroService, LivroService>();

builder.Services.AddCors();

var con = builder.Configuration.GetConnectionString("DefaultConnection");   

builder.Services.AddDbContext<LivroDbContext>(op => op.UseMySql(con, new MySqlServerVersion(new Version(8, 3, 0))));

var app = builder.Build();

app.UseCors(op => op.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
