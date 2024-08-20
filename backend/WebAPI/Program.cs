using Microsoft.EntityFrameworkCore;
using VeridiaAPI.Application.Services;
using VeridiaAPI.Core.Interfaces;
using VeridiaAPI.Infrastructure;
using VeridiaAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configura o contexto do banco de dados
builder.Services.AddDbContext<VeridiaContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registra os repositórios
builder.Services.AddScoped<IMundoRepository, MundoRepository>();
builder.Services.AddScoped<IRacaRepository, RacaRepository>();

// Registra os serviços
builder.Services.AddScoped<MundoService>();
builder.Services.AddScoped<RacaService>(); // Adicione esta linha para o RacaService

builder.Services.AddControllers();  // Adiciona suporte a Controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // Mapeia automaticamente os controllers

app.Run();
