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
    [Migration("20210115211954_AddedSlotForeignKeys")]
    partial class AddedSlotForeignKeys
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterCustomizableSlot<Glader.ASP.RPG.TestCustomizationSlotType, Glader.ASP.RPG.TestColorType>", b =>
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterProportionSlot<Glader.ASP.RPG.TestProportionSlotType, Glader.ASP.RPG.TestVectorType<float>>", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SlotType")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SlotType");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SlotType");

                    b.ToTable("character_proportion_slot");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterProportionSlotType<Glader.ASP.RPG.TestProportionSlotType>", b =>
                {
                    b.Property<int>("SlotType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SlotType");

                    b.ToTable("character_proportion_slot_type");

                    b.HasData(
                        new
                        {
                            SlotType = 0,
                            Description = "",
                            VisualName = "Wrists"
                        },
                        new
                        {
                            SlotType = 1,
                            Description = "",
                            VisualName = "Thighs"
                        },
                        new
                        {
                            SlotType = 2,
                            Description = "",
                            VisualName = "Butt"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacter", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterProgress", "Progress")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterCustomizableSlot<Glader.ASP.RPG.TestCustomizationSlotType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterCustomizableSlotType<Glader.ASP.RPG.TestCustomizationSlotType>", "SlotDefinition")
                        .WithMany()
                        .HasForeignKey("SlotType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Glader.ASP.RPG.TestColorType", "SlotColor", b1 =>
                        {
                            b1.Property<int>("DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>CharacterId")
                                .HasColumnType("int");

                            b1.Property<int>("DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>SlotType")
                                .HasColumnType("int");

                            b1.Property<int>("B")
                                .HasColumnType("int");

                            b1.Property<int>("G")
                                .HasColumnType("int");

                            b1.Property<int>("R")
                                .HasColumnType("int");

                            b1.HasKey("DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>CharacterId", "DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>SlotType");

                            b1.ToTable("character_customization_slot");

                            b1.WithOwner()
                                .HasForeignKey("DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>CharacterId", "DBRPGCharacterCustomizableSlot<TestCustomizationSlotType, TestColorType>SlotType");
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterOwnership", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterProportionSlot<Glader.ASP.RPG.TestProportionSlotType, Glader.ASP.RPG.TestVectorType<float>>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterProportionSlotType<Glader.ASP.RPG.TestProportionSlotType>", "SlotDefinition")
                        .WithMany()
                        .HasForeignKey("SlotType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Glader.ASP.RPG.TestVectorType<float>", "Proportion", b1 =>
                        {
                            b1.Property<int>("DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>CharacterId")
                                .HasColumnType("int");

                            b1.Property<int>("DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>SlotType")
                                .HasColumnType("int");

                            b1.Property<float>("X")
                                .HasColumnType("float");

                            b1.Property<float>("Y")
                                .HasColumnType("float");

                            b1.Property<float>("Z")
                                .HasColumnType("float");

                            b1.HasKey("DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>CharacterId", "DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>SlotType");

                            b1.ToTable("character_proportion_slot");

                            b1.WithOwner()
                                .HasForeignKey("DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>CharacterId", "DBRPGCharacterProportionSlot<TestProportionSlotType, TestVectorType<float>>SlotType");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
