using MMORPG.Game.Service.Domain.Entities.Base;
using MMORPG.Game.Service.Domain.Events.Person;

namespace MMORPG.Game.Service.Domain.Entities.Person
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public int Kills { get; set; }
        public List<AbilitiesPerson> AbilitiesPerson { get; set; }
        public List<PersonItem> PersonItems { get; set; }

        public void CreatePersonEvent() {
            AppendEvent(new CreatedPersonEvent() { 
                Name = Name,
                Id = Id
            });
        }

        public void AppendIem(PersonItem item) 
        {
            if (PersonItems.Count <= 10)
            {
                PersonItems.Add(item);
            }
        }

        //public void CreateEvenAppendNewItem(PersonItem item) {
        //    AppendEvent(new AppendItemPersonEvent()
        //    {
        //        Id = 
        //    });
        //}

        public void AppendAbilitie(AbilitiesPerson abilitie)
        {
            if (AbilitiesPerson.Count <= 20) {
                AbilitiesPerson.Add(abilitie);
            }
        }
    }
}
