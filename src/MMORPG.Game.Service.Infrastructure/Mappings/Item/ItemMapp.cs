using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain = MMORPG.Game.Service.Domain.Entities;

namespace MMORPG.Game.Service.Infrastructure.Mappings.Item
{
    public class ItemMapp : IEntityTypeConfiguration<Domain.Entities.Item.Item>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Item.Item> builder)
        {
            builder.ToTable("tb_item");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("cd_item_pk");

            builder.Property(x => x.Name).HasColumnName("nm_name");

            builder.Property(x => x.Description).HasColumnName("nm_description");

            builder.Property(x => x.Damage).HasColumnName("nr_damage");

            builder.HasMany(x => x.PersonItems).WithOne(x => x.Item).HasForeignKey(x => x.ItemId);
        }
    }
}
