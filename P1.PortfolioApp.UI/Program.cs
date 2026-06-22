using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using P1.PortfolioApp.Core.Configuration;
using P1.PortfolioApp.UI.Components;
using P1.PortfolioApp.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<ApiSettings>(
    builder.Configuration.GetSection("ApiSettings"));

builder.Services.AddScoped(sp =>
{
    var apiSettings = sp
        .GetRequiredService<IOptions<ApiSettings>>()
        .Value;

    return new HttpClient
    {
        BaseAddress = new Uri(apiSettings.BaseUrl)
    };

});

builder.Services.AddScoped<PortfolioApiClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
