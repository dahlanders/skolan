using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EfSamurai.Data;

namespace EfSamuari.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20170507122324_BattleEventBackReference")]
    partial class BattleEventBackReference
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSamuari.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsBrutal");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("EfSamuari.Domain.BattleEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattleLogId");

                    b.Property<string>("Description");

                    b.Property<int>("Order");

                    b.Property<string>("Summary");

                    b.HasKey("Id");

                    b.HasIndex("BattleLogId");

                    b.ToTable("BattleEvent");
                });

            modelBuilder.Entity("EfSamuari.Domain.BattleLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BattleId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BattleId")
                        .IsUnique();

                    b.ToTable("BattleLog");
                });

            modelBuilder.Entity("EfSamuari.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SamuraiId");

                    b.Property<int?>("Style");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EfSamuari.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("HairStyle");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EfSamuari.Domain.SamuraiBattle", b =>
                {
                    b.Property<int>("BattleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiBattle");
                });

            modelBuilder.Entity("EfSamuari.Domain.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RealName");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("SecretIdentity");
                });

            modelBuilder.Entity("EfSamuari.Domain.BattleEvent", b =>
                {
                    b.HasOne("EfSamuari.Domain.BattleLog", "BattleLog")
                        .WithMany("BattleEvents")
                        .HasForeignKey("BattleLogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuari.Domain.BattleLog", b =>
                {
                    b.HasOne("EfSamuari.Domain.Battle", "Battle")
                        .WithOne("BattleLog")
                        .HasForeignKey("EfSamuari.Domain.BattleLog", "BattleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuari.Domain.Quote", b =>
                {
                    b.HasOne("EfSamuari.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuari.Domain.SamuraiBattle", b =>
                {
                    b.HasOne("EfSamuari.Domain.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfSamuari.Domain.Samurai", "Samurai")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamuari.Domain.SecretIdentity", b =>
                {
                    b.HasOne("EfSamuari.Domain.Samurai", "Samurai")
                        .WithOne("SecretIdentity")
                        .HasForeignKey("EfSamuari.Domain.SecretIdentity", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
