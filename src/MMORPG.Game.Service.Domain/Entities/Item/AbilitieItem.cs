using EntityAbilitie = MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Entities.Item
{
    public class AbilitieItem : Entity
    {
        public AbilitieItem()
        {
            
        }

        public int AbilitieId { get; set; }
        public int ItemId { get; set; }

        public EntityAbilitie.Abilitie Abilitie { get; set; }
        public Item Item { get; set; }

    }
}
