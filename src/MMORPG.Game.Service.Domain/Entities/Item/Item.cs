using MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Entities.Base;
using MMORPG.Game.Service.Domain.Entities.Person;
using MMORPG.Game.Service.Domain.Events.Abilitie;
using MMORPG.Game.Service.Domain.Events.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Entities.Item
{
    public class Item : Entity
    {
        public Item()
        {
            
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public List<AbilitieItem> AbilitiesItem { get; set; }
        public List<PersonItem> PersonItems { get; set; }

        public void AppendAbilitie(AbilitieItem abilitie) {
            AbilitiesItem.Add(abilitie);
        }

        public void CreateEventAppendNewAbilitie(AbilitieItem abilitie) {
            AppendEvent(new AppendAbiltieItemEvent() {
                Id = abilitie.Id,
                AbilitieId = abilitie.AbilitieId,
                ItemId = abilitie.ItemId
            });
        }

        public void CreatedNewItemEvent() {
            AppendEvent(new CreatedItemEvent()
            {
                Id = Id,
                Name = Name,
                Damage = Damage,
                Description = Description
            });
        }
    }
}
