using Marten;
using Microsoft.Extensions.DependencyInjection;

namespace MMORPG.Game.Service.Infrastructure.IOC
{
    public static class MartenConfigurations
    {
        public static void AddMartenConfiguration(this IServiceCollection services) {
            services.AddMarten(configuration => {
                configuration.Connection("host=127.0.0.1;port=5432;database=postgres;user id=postgres;password=1234;");
            });
        }
    }
}
