using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMORPG.Game.Service.Domain.Entities.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Person
{
    public class PersonItemMapp : IEntityTypeConfiguration<PersonItem>
    {
        public void Configure(EntityTypeBuilder<PersonItem> builder)
        {
            builder.ToTable("rl_person_item");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_person_item_pk");

            builder.Property(x => x.ItemId).HasColumnName("cd_item_fk").IsRequired();
            builder.Property(x => x.PersonId).HasColumnName("cd_person_fk").IsRequired();

            builder.HasOne(x => x.Item).WithMany(x => x.PersonItems).HasForeignKey(x => x.ItemId);
            builder.HasOne(x => x.Person).WithMany(x => x.PersonItems).HasForeignKey(x => x.PersonId);
        }
    }
}
