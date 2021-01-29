﻿// <auto-generated />
using System;
using Glader.ASP.RPG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Glader.ASP.RPG.Application.Migrations
{
    [DbContext(typeof(RPGCharacterDatabaseContext<TestCustomizationSlotType, TestColorType, TestProportionSlotType, TestVectorType<float>>))]
    [Migration("20210114011044_SwappedEnumValue")]
    partial class SwappedEnumValue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("character");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterCustomizableSlot<Glader.ASP.RPG.TestCustomizationSlotType>", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SlotType")
                        .HasColumnType("int");

                    b.Property<int>("CustomizationId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SlotType");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SlotType");

                    b.ToTable("character_customization_slot");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterCustomizableSlotType<Glader.ASP.RPG.TestCustomizationSlotType>", b =>
                {
                    b.Property<int>("SlotType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SlotType");

                    b.ToTable("character_customization_slot_type");

                    b.HasData(
                        new
                        {
                            SlotType = 0,
                            Description = "",
                            VisualName = "Shoes"
                        },
                        new
                        {
                            SlotType = 1,
                            Description = "",
                            VisualName = "Feet"
                        },
                        new
                        {
                            SlotType = 2,
                            Description = "",
                            VisualName = "Shirt"
                        },
                        new
                        {
                            SlotType = 3,
                            Description = "",
                            VisualName = "Pants"
                        },
                        new
                        {
                            SlotType = 4,
                            Description = "",
                            VisualName = "Hair"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterOwnership", b =>
                {
                    b.Property<int>("OwnershipId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("OwnershipId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("OwnershipId");

                    b.ToTable("character_ownership");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("PlayTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("time(6)")
                        .HasDefaultValue(new TimeSpan(0, 0, 0, 0, 0));

                    b.HasKey("Id");

                    b.ToTable("character_progress");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacter", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterProgress", "Progress")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterCustomizableSlot<Glader.ASP.RPG.TestCustomizationSlotType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterCustomizableSlotType<Glader.ASP.RPG.TestCustomizationSlotType>", "SlotDefinition")
                        .WithMany()
                        .HasForeignKey("SlotType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterOwnership", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
