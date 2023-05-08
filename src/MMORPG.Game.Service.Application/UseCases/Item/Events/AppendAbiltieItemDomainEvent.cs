using MediatR;
using MMORPG.Game.Service.Domain.Events.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Application.UseCases.Item.Events
{
    public class AppendAbiltieItemDomainEvent : INotificationHandler<AppendAbiltieItemEvent>
    {
        public async Task Handle(AppendAbiltieItemEvent notification, CancellationToken cancellationToken)
        {
            //
        }
    }
}
