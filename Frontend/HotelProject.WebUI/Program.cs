using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritabaný baðlantý dizesi
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext için veritabaný saðlayýcýsýný ekleyin
builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(connectionString);
});

// Identity yapýlandýrmasý
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

// Diðer servislerin eklenmesi
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();

// Geliþtirme ve üretim ortamý yapýlandýrmasý
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Kimlik doðrulama ve yetkilendirme
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=default}/{action=Index}/{id?}");

app.Run();
