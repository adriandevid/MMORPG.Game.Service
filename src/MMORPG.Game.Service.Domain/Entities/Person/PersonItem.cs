using MMORPG.Game.Service.Domain.Entities.Base;
using DomainItem  = MMORPG.Game.Service.Domain.Entities.Item;

namespace MMORPG.Game.Service.Domain.Entities.Person
{
    public class PersonItem : Entity
    {
        public PersonItem()
        {
            
        }

        public int PersonId { get; set; }
        public int ItemId { get; set; }

        public DomainItem.Item Item { get; set; }
        public Person Person { get; set; }
    }
}
