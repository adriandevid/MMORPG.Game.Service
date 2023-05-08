using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Interfaces.Events
{
    public interface IEvent : INotification
    {
        int Id { get; set; }
    }
}
