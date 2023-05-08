using Marten;
using MediatR;
using MMORPG.Game.Service.Domain.Entities.Base;
using MMORPG.Game.Service.Domain.Interfaces.Events;
using MMORPG.Game.Service.Infrastructure.Context;

namespace MMORPG.Game.Service.Infrastructure.Extencions
{
    public static class MediatorExtension
    {
        public static async Task<List<IEvent>> DispatchDomainEventsAsync(this IMediator mediator, ApplicationContext context)
        {
            var entities = context.ChangeTracker.Entries<Entity>();

            var eventsOfDomain = entities.Where(x => x.Entity._events.Count > 0)
                .SelectMany(x => x.Entity._events)
                .ToList();

            entities.ToList().ForEach(e =>
            {
                e.Entity.CleanEvents();
            });

            eventsOfDomain.ToList().ForEach(e => {
                mediator.Publish(e);
            });

            return eventsOfDomain.ToList();
        }
    }
}
