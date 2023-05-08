using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Interfaces.Repositories.Base
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync(Action createEvents);
    }
}
