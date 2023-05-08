using Marten;
using MMORPG.Game.Service.Domain.Interfaces.Events;

namespace MMORPG.Game.Service.Infrastructure.Extencions
{
    public static class MartenExtension
    {
        public static async Task AppendDocumentStore(this List<IEvent> events, IDocumentSession documentSession) {
            foreach (object obj in events)
            {
                documentSession.Store(obj);
            }

            await documentSession.SaveChangesAsync();
        }
    }
}
