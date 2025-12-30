namespace MVC_Blank_Template
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            #region app.Map- GET , POST, PUT, DELETE
            /*app.MapGet("/", () => "GET: Hello World Sakshiiiiii!");
            app.MapPost("/", () => "Post: Hello World Sakshiiiiii!");
            app.MapPut("/", () => "Put: Hello World Sakshiiiiii!");
            app.MapDelete("/", () => "Delete: Hello World Sakshiiiiii!");*/
            #endregion

            #region app.run() can not pass http context reference to next method
            /*app.Run(async(context) => {
                await context.Response.WriteAsync("Hello Peter Parker!");
                await context.Response.WriteAsync("\nHow are you?");
            });

            app.Run(async(context) => {
                await context.Response.WriteAsync("\nBye bye Peter Parker");
            });*/
            #endregion

            #region app.Use()
            app.Use(async(context, next) => {
                await context.Response.WriteAsync("Hello Peter Parker!");
                await context.Response.WriteAsync("\nHow are you?");
                next(context);
            });

            app.Use(async (context, next) => {
                await context.Response.WriteAsync("\nSpiderMan");
                next(context);
                await context.Response.WriteAsync("\nAndrew Garfield");
            });

            app.Run(async (context) => {
                await context.Response.WriteAsync("\nBye Bye Peter Parker!!");
            });
            #endregion


            app.Run();


        }
    }
}
