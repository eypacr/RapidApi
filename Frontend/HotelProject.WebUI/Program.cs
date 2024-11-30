using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Mapping;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Veritaban� ba�lant� dizesi
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext i�in veritaban� sa�lay�c�s�n� ekleyin
builder.Services.AddDbContext<Context>(options =>
{
    options.UseSqlServer(connectionString);
});

// Identity yap�land�rmas�
builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<Context>()
    .AddDefaultTokenProviders();

// Di�er servislerin eklenmesi
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();

// Geli�tirme ve �retim ortam� yap�land�rmas�
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Kimlik do�rulama ve yetkilendirme
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=default}/{action=Index}/{id?}");

app.Run();
