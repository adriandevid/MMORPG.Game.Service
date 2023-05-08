using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Domain.Events.Person
{
    public class AppendItemPersonEvent : IEvent
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int PersonId { get; set; }
    }
}
