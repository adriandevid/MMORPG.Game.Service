using MediatR;
using MMORPG.Game.Service.Domain.Events.Item;

namespace MMORPG.Game.Service.Application.UseCases.Item.Events
{
    public class CreatedItemDomainEvent : INotificationHandler<CreatedItemEvent>
    {
        public async Task Handle(CreatedItemEvent notification, CancellationToken cancellationToken)
        {
            //
        }
    }
}
