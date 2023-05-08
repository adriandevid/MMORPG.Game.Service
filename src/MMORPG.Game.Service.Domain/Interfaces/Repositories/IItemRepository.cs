using MMORPG.Game.Service.Domain.Entities.Item;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;

namespace MMORPG.Game.Service.Domain.Interfaces.Repositories
{
    public interface IItemRepository : IBaseRepository<Item>
    {
        Task<Item> GetItemByIdWithIncludes(int id);
    }
}
