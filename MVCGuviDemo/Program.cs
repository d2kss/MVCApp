using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCGuviDemo.Data;
using MVCGuviDemo.Repository;
using MVCGuviDemo.Repository.Interfaces;
/* configuring services*/
var builder = WebApplication.CreateBuilder(args);
/* configuring services*/
builder.Services.AddDbContext<MVCGuviDemoContext>(options =>
/* configuring services*/
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCGuviDemoContext") ?? throw new InvalidOperationException("Connection string 'MVCGuviDemoContext' not found.")));

builder.Services.AddScoped<IProductCategory, ProductCategory>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


/* configuring services*/
/*using configuredn service */


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Categories}/{action=Index}/{id?}");


app.Run();
