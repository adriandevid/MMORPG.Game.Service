using AbilitieEntity = MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie;
using MMORPG.Game.Service.Infrastructure.Repositories.Base;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;
using MMORPG.Game.Service.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MMORPG.Game.Service.Infrastructure.Repositories.Abilitie
{
    public class AbilitieRepository : BaseRepository<AbilitieEntity>, IAbiliteRepository
    {
        public AbilitieRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<AbilitieEntity> GetAbilitieByIdWithIncludes(int id)
        {
            return await _dbSet.Include(x => x.AbilitiesPerson).Include(x => x.AbilitiesItem).FirstOrDefaultAsync();
        }
    }
}
