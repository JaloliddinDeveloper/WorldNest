using System.Net;
using WorldNest.Services.Countries;
using WorldNest.Services.Oceans;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

      

        // Servislarni qo'shish
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<CountryService>();
        builder.Services.AddScoped<OceanService>();

        var app = builder.Build();

        // Iftimoiy muhiti tekshirish
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        // HTTP so'rovlarining HTTPS-ga yo'naltirilishini ta'minlash
        app.UseHttpsRedirection();

        // Statik fayllarni ko'rsatish
        app.UseStaticFiles();

        // Routing tizimini ishga tushurish
        app.UseRouting();

        // Avtorizatsiya tizimini ishga tushurish
        app.UseAuthorization();

        // Kontroller yo'riqnomalarini belgilash
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        // Ilovani ishga tushurish
        app.Run();
    }
}
