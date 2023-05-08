using MMORPG.Game.Service.Domain.Interfaces.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Domain.Events.Abilitie
{
    public class CreatedAbilitieEvent : IEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }
    }
}
