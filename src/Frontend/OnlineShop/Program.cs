using Microsoft.AspNetCore.Components.Authorization;
using OnlineShop.Services.Basket;
using OnlineShop.Services.Catalog;
using OnlineShop.Services.Identity;
using OnlineShop.Services.Ordering;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<IdentityAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
builder.Services.AddScoped<IAuthorizeApi, AuthorizeApi>();
builder.Services.AddSingleton<CatalogService>();
builder.Services.AddSingleton<BasketService>();
builder.Services.AddSingleton<OrderService>();


builder.Services.AddHttpClient("Ocelot", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["HttpConfig:OcelotUrl"]);
    client.DefaultRequestHeaders.Add("Accept", "application/json; charset=utf-8");
});

builder.Services.AddHttpClient("Auth", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["HttpConfig:AuthUrl"]);
    client.DefaultRequestHeaders.Add("Accept", "application/json; charset=utf-8");
});

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