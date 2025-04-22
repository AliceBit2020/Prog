using Prog.Services;
using Prog.Infrastructure;
using Microsoft.AspNetCore.Authentication.Cookies;
using Prog.Model;
namespace Prog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ///depandency injections

            builder.Services.AddSingleton<IMyLogger, MyLogger>();
            builder.Services.AddSingleton<ExceptionLogAttribute>();
            builder.Services.AddScoped<User>();
            builder.Services.AddTransient<ISignIn,SignInCookie>();

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddMvcOptions(options=>
                {
                    options.Filters.AddService<ExceptionLogAttribute>();// з залежностями
                }
                );
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Home/Login";
            });
        
                

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseAuthentication();
			app.UseAuthorization();

			app.UseStaticFiles();

            app.UseRouting();

        

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }




       
    }



    
}
