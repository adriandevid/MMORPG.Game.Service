using Microsoft.Extensions.DependencyInjection;

namespace MMORPG.Game.Service.Infrastructure.IOC
{
    public static class Mediatr
    {
        public static void AddMediatrConfiguration(this IServiceCollection services) {
            services.AddMediatR((mediatr) => mediatr.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.Load("MMORPG.Game.Service.Application")));
        }
    }
}
