using Microsoft.EntityFrameworkCore;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;
using MMORPG.Game.Service.Infrastructure.Context;
using MMORPG.Game.Service.Infrastructure.Repositories.Base;

namespace MMORPG.Game.Service.Infrastructure.Repositories.Item
{
    public class ItemRepository : BaseRepository<MMORPG.Game.Service.Domain.Entities.Item.Item>, IItemRepository
    {
        public ItemRepository(ApplicationContext context) : base(context)
        {

        }

        public async Task<Domain.Entities.Item.Item> GetItemByIdWithIncludes(int id)
        {
            return await _dbSet.Include(x => x.AbilitiesItem).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
