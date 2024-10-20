var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapControllerRoute(
    name: "def",
    pattern: "{controller=Home}/{Action=Index}/{id?}");

app.Run();
