using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ArcadeScore API",
        Version = "v1",
        Description = "API REST para registrar pontuações de fliperama"
    });
});

var app = builder.Build();

// Configura o pipeline HTTP
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArcadeScore API v1");
    c.RoutePrefix = string.Empty; // Exibe o Swagger na raiz do site
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();