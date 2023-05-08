﻿// <auto-generated />
using MMORPG.Game.Service.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MMORPG.Game.Service.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_abilitie_pk");

                    b.Property<string>("Command")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_command");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_name");

                    b.HasKey("Id");

                    b.ToTable("tb_abilitie", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Item.AbilitieItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_abilitie_item_pk");

                    b.Property<int>("AbilitieId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_abilitie_fk");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_item_fk");

                    b.HasKey("Id");

                    b.HasIndex("AbilitieId");

                    b.HasIndex("ItemId");

                    b.ToTable("rl_abilitie_item", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Item.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_item_pk");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER")
                        .HasColumnName("nr_damage");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_name");

                    b.HasKey("Id");

                    b.ToTable("tb_item", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.AbilitiesPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_abilitie_person_pk");

                    b.Property<int>("AbilitieId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_abilitie_fk");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_person_fk");

                    b.HasKey("Id");

                    b.HasIndex("AbilitieId");

                    b.HasIndex("PersonId");

                    b.ToTable("rl_abilitie_person", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_person_pk");

                    b.Property<int>("Kills")
                        .HasColumnType("INTEGER")
                        .HasColumnName("nr_kills");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("nm_name");

                    b.Property<int>("Years")
                        .HasColumnType("INTEGER")
                        .HasColumnName("nr_years");

                    b.HasKey("Id");

                    b.ToTable("tb_person", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.PersonItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_person_item_pk");

                    b.Property<int>("ItemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_item_fk");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("cd_person_fk");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("PersonId");

                    b.ToTable("rl_person_item", (string)null);
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Item.AbilitieItem", b =>
                {
                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie", "Abilitie")
                        .WithMany("AbilitiesItem")
                        .HasForeignKey("AbilitieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Item.Item", "Item")
                        .WithMany("AbilitiesItem")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abilitie");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.AbilitiesPerson", b =>
                {
                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie", "Abilitie")
                        .WithMany("AbilitiesPerson")
                        .HasForeignKey("AbilitieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Person.Person", "Person")
                        .WithMany("AbilitiesPerson")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abilitie");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.PersonItem", b =>
                {
                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Item.Item", "Item")
                        .WithMany("PersonItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMORPG.Game.Service.Domain.Entities.Person.Person", "Person")
                        .WithMany("PersonItems")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Abilitie.Abilitie", b =>
                {
                    b.Navigation("AbilitiesItem");

                    b.Navigation("AbilitiesPerson");
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Item.Item", b =>
                {
                    b.Navigation("AbilitiesItem");

                    b.Navigation("PersonItems");
                });

            modelBuilder.Entity("MMORPG.Game.Service.Domain.Entities.Person.Person", b =>
                {
                    b.Navigation("AbilitiesPerson");

                    b.Navigation("PersonItems");
                });
#pragma warning restore 612, 618
        }
    }
}