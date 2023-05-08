using MediatR;
using MMORPG.Game.Service.Domain.Events.Person;

namespace MMORPG.Game.Service.Application.UseCases.Person.Events
{
    public class CreatedPersonDomainEvent : INotificationHandler<CreatedPersonEvent>
    {
        public async Task Handle(CreatedPersonEvent notification, CancellationToken cancellationToken)
        {
            //
        }
    }
}
