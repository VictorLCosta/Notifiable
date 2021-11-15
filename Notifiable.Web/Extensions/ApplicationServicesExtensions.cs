using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notifiable.Application.AutoMapperConfig;
using Notifiable.Application.Interfaces;
using Notifiable.Application.PasswordHasher;
using Notifiable.Application.Services;

namespace Notifiable.Web.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<Hasher, Hasher>();

            services.AddAutoMapper(typeof(ProfileMap).Assembly);

            return services;
        }
    }
}
