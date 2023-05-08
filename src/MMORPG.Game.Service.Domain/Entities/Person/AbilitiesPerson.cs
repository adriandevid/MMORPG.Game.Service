using MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Entities.Base;
using EntityAbilitie = MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Entities.Person
{
    public class AbilitiesPerson : Entity
    {
        public AbilitiesPerson()
        {
            
        }

        public int PersonId { get; set; }
        public int AbilitieId { get; set; }

        public EntityAbilitie Abilitie { get; set; }
        public Person Person { get; set; }
    }
}
