﻿// <auto-generated />
using System;
using LatijnData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LatijnData.Migrations
{
    [DbContext(typeof(LatijnDbContext))]
    [Migration("20250115205155_Connections")]
    partial class Connections
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("LatijnData.Models.SessionEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DocentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("LatijnData.Models.ToetsEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AantalGoed")
                        .HasColumnType("int");

                    b.Property<int>("AantalVragen")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Toetsen");
                });

            modelBuilder.Entity("LatijnData.Models.UitgangEF", b =>
                {
                    b.Property<int>("UitgangID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UitgangID"));

                    b.Property<int>("Conjugatie")
                        .HasColumnType("int");

                    b.Property<string>("Genus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Getal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Modus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Persoon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Stam")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tempus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Vorm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UitgangID");

                    b.ToTable("Uitgangen");
                });

            modelBuilder.Entity("LatijnData.Models.VervoegingEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Betekenis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Conjugatie")
                        .HasColumnType("int");

                    b.Property<string>("Genus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Getal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Infinitivus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Modus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Perfectum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Persoon")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Praesens")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Supinum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tempus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ToetsId")
                        .HasColumnType("int");

                    b.Property<string>("Vorm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ToetsId");

                    b.ToTable("Vervoegingen");
                });

            modelBuilder.Entity("LatijnData.Models.WerkwoordEF", b =>
                {
                    b.Property<int>("WoordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("WoordID"));

                    b.Property<string>("Betekenis")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Conjugatie")
                        .HasColumnType("int");

                    b.Property<string>("Infinitivus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Perfectum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Praesens")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Supinum")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("WoordID");

                    b.ToTable("Werkwoorden");
                });

            modelBuilder.Entity("LatijnData.Models.ToetsEF", b =>
                {
                    b.HasOne("LatijnData.Models.SessionEF", "Session")
                        .WithMany("ToetsenEF")
                        .HasForeignKey("SessionId");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("LatijnData.Models.VervoegingEF", b =>
                {
                    b.HasOne("LatijnData.Models.ToetsEF", "Toets")
                        .WithMany("VervoegingenEF")
                        .HasForeignKey("ToetsId");

                    b.Navigation("Toets");
                });

            modelBuilder.Entity("LatijnData.Models.SessionEF", b =>
                {
                    b.Navigation("ToetsenEF");
                });

            modelBuilder.Entity("LatijnData.Models.ToetsEF", b =>
                {
                    b.Navigation("VervoegingenEF");
                });
#pragma warning restore 612, 618
        }
    }
}