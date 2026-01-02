namespace Convential_Custom_Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            //app.MapDefaultControllerRoute();
            app.MapControllerRoute(
                name: "home",
                pattern: "{controller=Home}/{action=Index}/{id}"
                //pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            
            app.MapControllerRoute(
                name: "user",
                pattern: "{controller=User}/{action=Index}"
            );

            app.MapControllerRoute(
                name: "admin",
                pattern: "{controller=Admin}/{action=Index}"
            );

            app.Run();
        }
    }
}
