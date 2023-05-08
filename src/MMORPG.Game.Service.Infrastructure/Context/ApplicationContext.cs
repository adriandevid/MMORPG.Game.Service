using Marten;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MMORPG.Game.Service.Domain.Entities.Abilitie;
using MMORPG.Game.Service.Domain.Entities.Item;
using MMORPG.Game.Service.Domain.Entities.Person;
using MMORPG.Game.Service.Domain.Interfaces.Repositories.Base;
using MMORPG.Game.Service.Infrastructure.Extencions;

namespace MMORPG.Game.Service.Infrastructure.Context
{
    public class ApplicationContext : DbContext, IUnitOfWork
    {
        private readonly IMediator _mediator;
        private readonly IDocumentSession _documentSession;

        public ApplicationContext()
        {
            
        }

        public ApplicationContext(IMediator mediator, IDocumentSession documentSession, DbContextOptions<ApplicationContext> options) : base(options)
        {
            _mediator = mediator;
            _documentSession = documentSession;
        }


        public DbSet<Item> Items { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonItem> PersonItems { get; set; }
        public DbSet<AbilitieItem> AbilitieItems { get; set; }
        public DbSet<Abilitie> Abilities { get; set; }
        public DbSet<AbilitiesPerson> AbilitiesPerson { get; set; }

        public async Task<bool> SaveChangesAsync(Action createEvents)
        {
            var resultSave = await base.SaveChangesAsync();
            createEvents();

            var eventsSaveds = await _mediator.DispatchDomainEventsAsync(this);
            await eventsSaveds.AppendDocumentStore(_documentSession);

            return resultSave > 0;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();

        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfigurationsFromAssembly(AppDomain.CurrentDomain.Load("MMORPG.Game.Service.Infrastructure"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
