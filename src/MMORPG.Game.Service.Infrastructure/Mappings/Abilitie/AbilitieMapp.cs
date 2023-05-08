using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EntityAbilitie = MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Abilitie
{
    public class AbilitieMapp : IEntityTypeConfiguration<EntityAbilitie>
    {
        public void Configure(EntityTypeBuilder<EntityAbilitie> builder)
        {
            builder.ToTable("tb_abilitie");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_abilitie_pk");
            builder.Property(x => x.Name).HasColumnName("nm_name");
            builder.Property(x => x.Description).HasColumnName("nm_description");
            builder.Property(x => x.Command).HasColumnName("nm_command");

            builder.HasMany(x => x.AbilitiesPerson).WithOne(x => x.Abilitie).HasForeignKey(x => x.AbilitieId);
            builder.HasMany(x => x.AbilitiesItem).WithOne(x => x.Abilitie).HasForeignKey(x => x.AbilitieId);
        }
    }
}
