using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MinApi;
using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICalculadoraService, CalculadoraService>();

await using var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/api/calcular", async http => 
{
    var parameters = await http.Request.ReadFromJsonAsync<Params>();

    var service = http.RequestServices.GetService<ICalculadoraService>();

    var data = await service.CalcularRentabilidade(parameters);

    await http.Response.WriteAsJsonAsync(data);
});

await app.RunAsync();
