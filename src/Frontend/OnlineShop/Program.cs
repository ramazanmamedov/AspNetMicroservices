using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using OnlineShop.Application.Basket;
using OnlineShop.Application.Catalog;
using OnlineShop.Data;
using OnlineShop.Pages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<CatalogService>();
builder.Services.AddSingleton<BasketService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();