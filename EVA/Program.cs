var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Apod",
    pattern: "apod/{date?}",
    defaults: new { controller = "Home", action = "Apod" });

app.MapControllerRoute(
    name: "aboutus",
    pattern: "aboutus",
    defaults: new { controller = "Home", action = "Aboutus" });

app.MapControllerRoute(
    name: "planets",
    pattern: "planets",
    defaults: new { controller = "Home", action = "Planets" });

app.MapControllerRoute(
    name: "galaxies",
    pattern: "galaxies",
    defaults: new { controller = "Home", action = "Galaxies" });

app.MapControllerRoute(
    name: "astronauts",
    pattern: "astronauts",
    defaults: new { controller = "Home", action = "Austronauts" });

app.Run();