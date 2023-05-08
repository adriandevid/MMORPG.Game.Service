using MediatR;
using MMORPG.Game.Service.Domain.Events.Abilitie;

namespace MMORPG.Game.Service.Application.UseCases.Abilitie.Events
{
    public class CreatedAbilitieDomainEvent : INotificationHandler<CreatedAbilitieEvent>
    {
        public async Task Handle(CreatedAbilitieEvent notification, CancellationToken cancellationToken)
        {
            //
        }
    }
}
