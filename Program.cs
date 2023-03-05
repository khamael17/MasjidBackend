using Masjid.Models;
using Masjid.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IHome, HomeService>();
builder.Services.AddScoped<IProfile, ProfileService>();

builder.Services.AddRazorPages();
builder.Services.AddDbContext<MasjidDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:MasjidDbContextConnection"]);
} );
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

app.MapRazorPages();
DbInitializer.Seed(app);
app.Run();
