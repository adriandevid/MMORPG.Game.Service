using Microsoft.EntityFrameworkCore;
using MMORPG.Game.Service.Domain.Entities.Base;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;
using MMORPG.Game.Service.Infrastructure.Context;

namespace MMORPG.Game.Service.Infrastructure.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        private ApplicationContext _context { get; set; }
        public DbSet<TEntity> _dbSet { get; set; }

        public IUnitOfWork UnitOfWork => _context;
        
        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
        public void Append(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
