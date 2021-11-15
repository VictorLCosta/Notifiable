using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notifiable.Data;
using Notifiable.Data.Interfaces;
using Notifiable.Data.Repositories;
using Notifiable.Data.Transaction;

namespace Notifiable.Web.Extensions
{
    public static class DataServicesExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlite(config.GetConnectionString("DefaultConnection"))
            );

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUow, Uow>();

            return services;
        }
    }
}
