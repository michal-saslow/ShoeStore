
using ShoeStore.Core.Repository;
using ShoeStore.Core.Services;
using ShoeStore.Data.RepositoryData;
using ShoeStore.Date;
using ShoeStore.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrderService, ServiceOrder>();
builder.Services.AddScoped<IProductService, ServiceProduct>();
builder.Services.AddScoped<IProviderService, ShoeStore.Service.ServiceProvider>();
builder.Services.AddScoped<IOrderRepository, OrderRpository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProviderRepository, ProviderRepository>();
builder.Services.AddDbContext<DataContext>();





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
