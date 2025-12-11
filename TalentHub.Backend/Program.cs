using Microsoft.EntityFrameworkCore;
using TalentHub.Application.Interfaces;
using TalentHub.Infrastructure.Persistence;
using TalentHub.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Generar menu
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Registramos la BD. - "Usa SQL Server y busca la dirección en appsettings.json"
builder.Services.AddDbContext<TalentHubDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Registramos la Inyección de Dependencias (El Contrato)
// "Cuando alguien pida IJobOfferRepository, dale una instancia de JobOfferRepository"
builder.Services.AddScoped<IJobOfferRepository, JobOfferRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
