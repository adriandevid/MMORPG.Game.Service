using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Domain.Events.Item
{
    public class CreatedItemEvent : IEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
    }
}
