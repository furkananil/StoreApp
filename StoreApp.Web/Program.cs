using Microsoft.EntityFrameworkCore;
using StoreApp.Data.Conrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(options => {
    options.UseSqlite(builder.Configuration["ConnectionStrings:StoreDbConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
