using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Domain.Events.Item
{
    public class AppendAbiltieItemEvent : IEvent
    {
        public int Id { get; set; }
        public int AbilitieId { get; set; }
        public int ItemId { get; set; }
    }
}
