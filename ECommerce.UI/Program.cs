using ECommerce.DataAccessLayer;
using ECommerce.DataAccessLayer.Infrastructure.Contraccts;
using ECommerce.DataAccessLayer.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ECommerceDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("SqliteConnectionString").ToString();
    options.UseSqlite(connectionString);
});

builder.Services.AddScoped<ICustomer, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
