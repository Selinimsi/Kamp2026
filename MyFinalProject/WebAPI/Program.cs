
using Busniess.Abstract;
using Busniess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFrameWork;


var builder = WebApplication.CreateBuilder(args);

// 🔹 Startup.cs → ConfigureServices karşılığı
builder.Services.AddControllers();

// Dependency Injection (EN ÖNEMLİ KISIM)
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductDal, EfProductDal>();

// Swagger (isteğe bağlı ama genelde var)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 🔹 Startup.cs → Configure karşılığı
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();