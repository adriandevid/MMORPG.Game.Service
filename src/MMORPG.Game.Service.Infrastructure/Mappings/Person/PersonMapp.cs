using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Domain = MMORPG.Game.Service.Domain;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Person
{
    public class PersonMapp : IEntityTypeConfiguration<Domain.Entities.Person.Person>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Domain.Entities.Person.Person> builder)
        {
            builder.ToTable("tb_person");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_person_pk");
            builder.Property(x => x.Name).HasColumnName("nm_name");
            builder.Property(x => x.Years).HasColumnName("nr_years");
            builder.Property(x => x.Kills).HasColumnName("nr_kills");

            builder.HasMany(x => x.PersonItems).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);
        }
    }
}
