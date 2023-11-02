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

//Obtendo uma sess�o de configura��o de hor�rio de funcionamento do sistema
//que est� configurado em: appsetings.json ("OpeningTime")
builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));

//Define inje��o de depend�ncia para banco de dados na mem�ria
builder.Services.AddSingleton<DevFreelaDbContext>();

//------------------------------------------------------------------------------------------------
//Com Singleton � a mesma instancia para todo aplica��o
//builder.Services.AddSingleton<ExampleClass>(e => new ExampleClass { Name = "Inicial stagge."});

builder.Services.AddScoped<IProjectService, ProjectService>();

//Com Scoped � uma inst�ncia para cada requisi��o.
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
