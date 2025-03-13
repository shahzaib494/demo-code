using KoperasiTentera.User.Abstraction.User;
using KoperasiTentera.User.Service.User;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KoperasiTentera.User.Module
{
    public static class AspNetCoreExtentions
    {
        public static IServiceCollection InitUserServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }

    }
}
