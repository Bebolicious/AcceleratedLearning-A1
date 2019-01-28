﻿// <auto-generated />
using System;
using EfSamurai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfSamurai.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    partial class SamuraiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfSamurai.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Brutal");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Enddate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Startdate");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("EfSamurai.Domain.BattleEvents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BattleLogId");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.HasIndex("BattleLogId");

                    b.ToTable("BattleEvents");
                });

            modelBuilder.Entity("EfSamurai.Domain.BattleLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BattleId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BattleId")
                        .IsUnique();

                    b.ToTable("BattleLogs");
                });

            modelBuilder.Entity("EfSamurai.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Angerlevel");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("EfSamurai.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<int>("Haircut");

                    b.Property<string>("Name");

                    b.Property<int?>("SeccretIdentityId");

                    b.HasKey("Id");

                    b.HasIndex("SeccretIdentityId");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("EfSamurai.Domain.SamuraiBattle", b =>
                {
                    b.Property<int>("SamuraiId");

                    b.Property<int>("BattleId");

                    b.Property<int?>("SamuraiBattleBattleId");

                    b.Property<int?>("SamuraiBattleSamuraiId");

                    b.HasKey("SamuraiId", "BattleId");

                    b.HasIndex("BattleId");

                    b.HasIndex("SamuraiBattleSamuraiId", "SamuraiBattleBattleId");

                    b.ToTable("SamuraiBattles");
                });

            modelBuilder.Entity("EfSamurai.Domain.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SecretIdentities");

                    b.HasKey("Id");

                    b.ToTable("SeccretIdentities");
                });

            modelBuilder.Entity("EfSamurai.Domain.BattleEvents", b =>
                {
                    b.HasOne("EfSamurai.Domain.BattleLog")
                        .WithMany("BattleEvents")
                        .HasForeignKey("BattleLogId");
                });

            modelBuilder.Entity("EfSamurai.Domain.BattleLog", b =>
                {
                    b.HasOne("EfSamurai.Domain.Battle", "Battle")
                        .WithOne("BattleLog")
                        .HasForeignKey("EfSamurai.Domain.BattleLog", "BattleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamurai.Domain.Quote", b =>
                {
                    b.HasOne("EfSamurai.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EfSamurai.Domain.Samurai", b =>
                {
                    b.HasOne("EfSamurai.Domain.SecretIdentity", "SeccretIdentity")
                        .WithMany()
                        .HasForeignKey("SeccretIdentityId");
                });

            modelBuilder.Entity("EfSamurai.Domain.SamuraiBattle", b =>
                {
                    b.HasOne("EfSamurai.Domain.Battle", "Battle")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfSamurai.Domain.Samurai", "Samurai")
                        .WithMany()
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EfSamurai.Domain.SamuraiBattle")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiBattleSamuraiId", "SamuraiBattleBattleId");
                });
#pragma warning restore 612, 618
        }
    }
}