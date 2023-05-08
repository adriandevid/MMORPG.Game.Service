using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMORPG.Game.Service.Domain.Entities.Item;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Item
{
    public class AbilitieItemMapp : IEntityTypeConfiguration<AbilitieItem>
    {
        public void Configure(EntityTypeBuilder<AbilitieItem> builder)
        {
            builder.ToTable("rl_abilitie_item");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_abilitie_item_pk");

            builder.Property(x => x.AbilitieId).HasColumnName("cd_abilitie_fk");
            builder.Property(x => x.ItemId).HasColumnName("cd_item_fk");

            builder.HasOne(x => x.Abilitie).WithMany(x => x.AbilitiesItem).HasForeignKey(x => x.AbilitieId);
            builder.HasOne(x => x.Item).WithMany(x => x.AbilitiesItem).HasForeignKey(x => x.ItemId);

        }
    }
}
