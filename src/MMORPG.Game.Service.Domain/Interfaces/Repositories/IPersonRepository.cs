

using MMORPG.Game.Service.Domain.Entities.Person;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;

namespace MMORPG.Game.Service.Domain.Interfaces.Repositories
{
    public interface IPersonRepository: IBaseRepository<Person>
    {
        Task<Domain.Entities.Person.Person> GetPersonByIdWithIncludes(int id);
    }
}
