using Microsoft.Extensions.DependencyInjection;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;
using MMORPG.Game.Service.Infrastructure.Repositories.Abilitie;
using MMORPG.Game.Service.Infrastructure.Repositories.Item;
using MMORPG.Game.Service.Infrastructure.Repositories.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Infrastructure.IOC
{
    public static class Repositories
    {
        public static void AddRepositoriesConfiguration(this IServiceCollection services) {
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IAbiliteRepository, AbilitieRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
        }
    }
}
