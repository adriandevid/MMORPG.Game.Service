using MediatR;
using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Domain.Entities.Base
{
    public class Entity
    {
        public int Id { get; set; }

        private List<IEvent> _domainEvents = new List<IEvent>();
        public IReadOnlyList<IEvent> _events => _domainEvents;

        public void AppendEvent(IEvent @event) { 
            _domainEvents.Add(@event);
        }

        public void CleanEvents() { 
            _domainEvents.Clear();
        }
    }
}
