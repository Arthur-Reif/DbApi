using Microsoft.EntityFrameworkCore;
using DbApi;
using DbApi.Repositories.Interfaces;
using DbApi.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options=> options.UseSqlServer(connection));

builder.Services.AddScoped<IClientesRepository, ClientesRepository>(); //Se eu colocasse ClienetesRepositoryMock no lugar de ClientesRepository, iria ser utilizada as coisas dentro do mock, mas como eu coloquei ClientesRepository, vai ser utilizada a classe ClientesRepository que é a que faz a conexão com o banco de dados.


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(op =>
    {
        op.SwaggerEndpoint("/openapi/v1.json", "v1");
    }); //precisa disso para visualizar o swagger
        // Disso tbm : <PackageReference Include="Swashbuckle.AspNetCore.SwaggerUI" Version="10.2.3" />
}

// app.UseHttpsRedirection();
app.MapControllers();

app.Run();

