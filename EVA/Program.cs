using EVA.IServices;
using EVA.Services;
using EVA.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using EVA.Repositories_regi.Abstract;
using EVA.Repositories_regi.Implementation;
using EVA.Models.GalaxyTable;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ApodService>();
builder.Services.AddScoped<IAboutUsService, AboutUsService>();
builder.Services.AddScoped<IAstronautsService, AstronautsService>();
builder.Services.AddScoped<IGalaxiesService, GalaxiesService>();
builder.Services.AddScoped<IPlanetsService,PlanetsService>();
builder.Services.AddScoped<IIndexService, IndexService>();

builder.Services.AddDbContext<GalaxyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("galaxy")));

builder.Services.AddDbContext<DatabaseContext>(options=> options.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
//for idenitity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<DatabaseContext>()
    .AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(op=> op.LoginPath="/UserAuthentication/Login");

builder.Services.AddScoped<IUserAuthenticationService, UserAuthenticationService>();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set session timeout
    options.Cookie.HttpOnly = true; // Configure session cookie
});

var app = builder.Build();


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

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();


app.MapControllerRoute(
   name: "index",
    pattern: "{controller=Index}/{action=Index}/{id?}",
    defaults: new { controller = "Index", action = "Index" });

app.MapControllerRoute(
    name: "apod",
    pattern: "apod",
    defaults: new { controller = "Home", action = "Apod" });


app.MapControllerRoute(
    name: "aboutus",
    pattern: "aboutus",
    defaults: new { controller = "AboutUs", action = "Aboutus" });

app.MapControllerRoute(
    name: "planets",
    pattern: "planets",
    defaults: new { controller = "Planets", action = "Planets" });

app.MapControllerRoute(
    name: "galaxies",
    pattern: "galaxies",
    defaults: new { controller = "Galaxies", action = "Galaxies" });

app.MapControllerRoute(
    name: "astronauts",
    pattern: "astronauts",
    defaults: new { controller = "Astronauts", action = "Astronauts" });

app.MapControllerRoute(
    name: "login",
    pattern: "/UserAuthentication/Login",
    defaults: new { controller = "UserAuthentication", action = "Login" });

app.MapControllerRoute(
    name: "dashboard",
    pattern: "/Dashboard/DashDisplay",
    defaults: new { controller = "Dashboard", action = "DashDisplay" });

app.MapControllerRoute(
    name: "logout",
    pattern: "/UserAuthentication/Logout",
    defaults: new { controller = "UserAuthentication", action = "Logout" });

app.MapControllerRoute(
    name: "registration",
    pattern: "UserAuthentication/Registration",
    defaults: new { controller = "UserAuthentication", action = "Registration" });

app.MapControllerRoute(
    name: "galaxiestable",
    pattern: "/GalaxiesTable/GalaxiesTableView",
    defaults: new { controller = "GalaxiesTable", action = "GalaxiesTableView" });

app.Run();