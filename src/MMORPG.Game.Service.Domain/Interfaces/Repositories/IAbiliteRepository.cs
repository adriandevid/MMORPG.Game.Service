using MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;

namespace MMORPG.Game.Service.Domain.Interfaces.Repositories
{
    public interface IAbiliteRepository : IBaseRepository<Abilitie>
    {
        Task<Domain.Entities.Abilitie.Abilitie> GetAbilitieByIdWithIncludes(int id);
    }
}
