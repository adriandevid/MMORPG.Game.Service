using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMORPG.Game.Service.Domain.Entities.Person;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Person
{
    public class AbilitiesPersonMapp : IEntityTypeConfiguration<AbilitiesPerson>
    {
        public void Configure(EntityTypeBuilder<AbilitiesPerson> builder)
        {
            builder.ToTable("rl_abilitie_person");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_abilitie_person_pk");

            builder.Property(x => x.AbilitieId).HasColumnName("cd_abilitie_fk");
            builder.Property(x => x.PersonId).HasColumnName("cd_person_fk");


            builder.HasOne(x => x.Person).WithMany(x => x.AbilitiesPerson).HasForeignKey(x => x.PersonId);
            builder.HasOne(x => x.Abilitie).WithMany(x => x.AbilitiesPerson).HasForeignKey(x => x.AbilitieId);

        }
    }
}
