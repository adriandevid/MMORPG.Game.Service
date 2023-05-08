using Microsoft.EntityFrameworkCore;
using MMORPG.Game.Service.Domain.Interfaces.Repositories;
using MMORPG.Game.Service.Infrastructure.Context;
using MMORPG.Game.Service.Infrastructure.Repositories.Base;

namespace MMORPG.Game.Service.Infrastructure.Repositories.Person
{
    public class PersonRepository : BaseRepository<MMORPG.Game.Service.Domain.Entities.Person.Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext context) : base(context)
        {
            
        }

        public async Task<Domain.Entities.Person.Person> GetPersonByIdWithIncludes(int id)
        {
            return await _dbSet.Include(x => x.AbilitiesPerson).Include(x => x.PersonItems).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
