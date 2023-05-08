using MediatR;
using MMORPG.Game.Service.Domain.Events.Person;

namespace MMORPG.Game.Service.Application.UseCases.Person.Events
{
    public class AppendAbilitiePersonDomainEvent : INotificationHandler<AppendAbilitiePersonEvent>
    {
        public async Task Handle(AppendAbilitiePersonEvent notification, CancellationToken cancellationToken)
        {
            //
           
        }
    }
}
