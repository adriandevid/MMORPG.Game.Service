

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;
using MMORPG.Game.Service.Infrastructure.Context;

namespace MMORPG.Game.Service.Infrastructure.IOC
{
    public static class ContextApplication
    {
        public static void AddContextConfiguration(this IServiceCollection services) {
            services.AddScoped<IUnitOfWork, ApplicationContext>();
            services.AddSqlite<ApplicationContext>("Data Source=../MMORPG.Game.Service.Infrastructure/Database/Game.db", options => options.MigrationsAssembly("EventSourcing.Service.Infrastructure"));
        }
    }
}
