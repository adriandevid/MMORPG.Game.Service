using MMORPG.Game.Service.Domain.Entities.Base;

namespace MMORPG.Game.Service.Domain.Interfaces.Repositories.Base
{
    public interface IBaseRepository<TEntityBase> where TEntityBase : Entity
    {
        IUnitOfWork UnitOfWork { get; }
        void Append(TEntityBase entity);
        void Remove(TEntityBase entity);
        void Update(TEntityBase entity);
        Task<TEntityBase> GetById(int id);
    }
}
