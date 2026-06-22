using P1.PortfolioApp.API.Endpoints;
using P1.PortfolioApp.API.Middleware;
using P1.PortfolioApp.Core.Configuration;
using P1.PortfolioApp.Core.Models;
using P1.PortfolioApp.Services;
using P1.PortfolioApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<SecclSettings>(
    builder.Configuration.GetSection("Seccl"));


builder.Services.AddHttpClient<
    ISecclService,
    SecclService>(client =>
    {
        client.BaseAddress =
            new Uri(
                builder.Configuration["Seccl:BaseUrl"]!);
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
builder.Services.AddSingleton<TokenCache>();
var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Serves the generated JSON document
    app.UseSwaggerUI(); // Serves the visual web interface
}

app.UseCors();
app.UseMiddleware<ExceptionMiddleware>();
app.MapPortfolioEndpoints();

app.Run();
