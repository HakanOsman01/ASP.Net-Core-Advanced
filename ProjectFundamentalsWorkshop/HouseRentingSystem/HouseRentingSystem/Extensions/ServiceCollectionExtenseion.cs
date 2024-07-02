

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HouseRentingSystem.Infrastructer.Data;

namespace Microsoft.Extensions.DependencyInjection 
{
    public static class ServiceCollectionExtenseion
    {
        public static IServiceCollection AddApllicationServices(
            this IServiceCollection services)
        {
            return services;
        }
        public static IServiceCollection AddApllicationDbContext(
            this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection") 
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<HouseRentingDbContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }
        public static IServiceCollection AddApllicationIdentity(
            this IServiceCollection services, IConfiguration config)
        {
            services
               .AddDefaultIdentity<IdentityUser>
                (options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireUppercase = false;
                }
               )
              .AddEntityFrameworkStores<HouseRentingDbContext>();
            return services;

        }
    }
}
