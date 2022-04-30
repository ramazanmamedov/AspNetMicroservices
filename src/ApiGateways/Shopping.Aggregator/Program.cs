using Shopping.Aggregator.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
// Add services to the container.


services.AddHttpClient<ICatalogService, CatalogService>(c => c.BaseAddress = new Uri(configuration["ApiSettings:CatalogUrl"]));
services.AddHttpClient<IBasketService, BasketService>(c => c.BaseAddress = new Uri(configuration["ApiSettings:BasketUrl"]));
services.AddHttpClient<IOrderService, OrderService>(c => c.BaseAddress = new Uri(configuration["ApiSettings:OrderingUrl"]));


services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

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