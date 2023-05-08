using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Domain.Events.Person
{
    public class CreatedPersonEvent : IEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
