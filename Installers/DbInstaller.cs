using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FestivalVar.Data;
using FestivalVar.Domain;
using FestivalVar.Services;

namespace FestivalVar.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<ApplicationUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<DataContext>();


            services.AddScoped<IFestivalService, FestivalService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IDrawService, DrawService>();
        }
    }
}