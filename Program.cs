using HW_3_4_5_Films_MVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? connection =builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<FilmContext>(options=>options.UseSqlServer(connection));

var app = builder.Build();




// Configure the HTTP request pipeline.



app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Films}/{action=Index}/{id?}");

app.Run();
