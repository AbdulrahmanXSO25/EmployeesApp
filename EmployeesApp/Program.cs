using EmployeesApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeesApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var Configuration = builder.Configuration;
            var Services = builder.Services;
            var ConnectionString = Configuration.GetConnectionString("DefaultConnection");
            Services.AddDbContext<EmployeesDbContext>(options
             => options.UseSqlServer(ConnectionString));


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
                pattern: "{controller=Employee}/{action=Index}/{id?}");

            app.Run();
        }
    }
}