using DatingApp.WebAPI.Data;
using DatingApp.WebAPI.Interfaces;
using DatingApp.WebAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.WebAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
           services.AddControllers();
           services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
           services.AddCors();
           services.AddScoped<ITokenService, TokenService>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
