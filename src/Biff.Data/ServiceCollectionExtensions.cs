using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Biff.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddEntityFramework(this IServiceCollection services, string connectionString)
        {
            services
                .AddDbContext<BiffContext>(options => options.UseSqlServer(connectionString));
        }

        public static void AddIdentity(this IServiceCollection services)
        {
            services
                .AddIdentity<BiffUser, IdentityRole>()
                .AddEntityFrameworkStores<BiffContext>()
                .AddDefaultTokenProviders();
        }
    }
}
