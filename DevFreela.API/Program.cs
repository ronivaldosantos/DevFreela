using DevFreela.API.Models;
using DevFreela.Aplication.Services.Implementations;
using DevFreela.Aplication.Services.Interfaces;
using DevFreela.Infrastruture.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Obtendo uma sessão de configuração de horário de funcionamento do sistema
//que está configurado em: appsetings.json ("OpeningTime")
builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));

//Define injeção de dependência para banco de dados na memória
builder.Services.AddSingleton<DevFreelaDbContext>();

//------------------------------------------------------------------------------------------------
//Com Singleton é a mesma instancia para todo aplicação
//builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Inicial stagge."});

builder.Services.AddScoped<IProjectService, ProjectService>();

//Com Scoped é uma instância para cada requisição.
builder.Services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Inicial stagge." });

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
