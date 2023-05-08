using MMORPG.Game.Service.Domain.Entities.Base;
using MMORPG.Game.Service.Domain.Entities.Item;
using MMORPG.Game.Service.Domain.Entities.Person;
using MMORPG.Game.Service.Domain.Events.Abilitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Entities.Abilitie
{
    public class Abilitie : Entity
    {
        public Abilitie()
        {
            
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }

        public List<AbilitiesPerson> AbilitiesPerson { get; set; }
        public List<AbilitieItem> AbilitiesItem { get; set; }

        public void CreateEventNewAbilite() {
            AppendEvent(new CreatedAbilitieEvent { 
                Id = Id,
                Name = Name,
                Description = Description,
                Command = Command
            });
        }
    }
}
