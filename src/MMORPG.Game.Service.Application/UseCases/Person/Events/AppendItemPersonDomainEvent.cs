using MediatR;
using MMORPG.Game.Service.Domain.Events.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Application.UseCases.Person.Events
{
    public class AppendItemPersonDomainEvent : INotificationHandler<AppendItemPersonEvent>
    {
        public async Task Handle(AppendItemPersonEvent notification, CancellationToken cancellationToken)
        {
            //
        }
    }
}
