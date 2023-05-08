using MMORPG.Game.Service.Domain.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Events.Person
{
    public class AppendAbilitiePersonEvent: IEvent
    {
        public int Id { get; set; }
        public int AbilitieId { get; set; }
        public int PersonId { get; set; }
    }
}
