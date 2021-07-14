﻿// <auto-generated />
using System;
using Glader.ASP.RPG;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Glader.ASP.RPGCharacter.Application.Migrations
{
    [DbContext(typeof(RPGCharacterDatabaseContext<TestCustomizationSlotType, TestColorType, TestProportionSlotType, TestVectorType<float>, TestRaceType, TestClassType, TestSkillType, TestStatType, TestItemClass, TestQualityType, TestColorType>))]
    partial class RPGCharacterDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.16")
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterDefinition<Glader.ASP.RPG.TestRaceType, Glader.ASP.RPG.TestClassType>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnName("Class")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnName("Race")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.ToTable("character_definition");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterItemInventory<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("OwnershipId")
                        .HasColumnType("int");

                    b.Property<int>("OwnershipType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("OwnershipId")
                        .IsUnique();

                    b.HasIndex("OwnershipId", "OwnershipType");

                    b.ToTable("character_item_inventory");

                    b.HasCheckConstraint("OwnershipType", "OwnershipType = 1");
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterSkillKnown<Glader.ASP.RPG.TestSkillType>", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnName("Skill")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SkillId");

                    b.ToTable("character_skill_known");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterSkillLevel<Glader.ASP.RPG.TestSkillType>", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnName("Skill")
                        .HasColumnType("int");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "SkillId");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SkillId");

                    b.ToTable("character_skill_level");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterStatDefault<Glader.ASP.RPG.TestStatType, Glader.ASP.RPG.TestRaceType, Glader.ASP.RPG.TestClassType>", b =>
                {
                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("RaceId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.HasKey("Level", "RaceId", "ClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("RaceId");

                    b.ToTable("character_stat_default");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGClass<Glader.ASP.RPG.TestClassType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("class");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            VisualName = "Warrior"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            VisualName = "Warlock"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

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

                    b.ToTable("group");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGGroupMember", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("GroupId");

                    b.ToTable("group_member");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemClass<Glader.ASP.RPG.TestItemClass>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("item_class");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            VisualName = "Weapon"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            VisualName = "Armor"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemInstance<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.ToTable("item_instance");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemInstanceOwnership<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("OwnershipType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id", "OwnershipType");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("item_instance_ownership");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemTemplate<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("QualityType")
                        .HasColumnType("int");

                    b.Property<int>("SubClassId")
                        .HasColumnType("int");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("QualityType");

                    b.HasIndex("ClassId", "SubClassId");

                    b.ToTable("item_template");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGQuality<Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("quality");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            VisualName = "Poor"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            VisualName = "Common"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            VisualName = "Uncommon"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            VisualName = "Rare"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            VisualName = "Epic"
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            VisualName = "Legendary"
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            VisualName = "Mythical"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGRace<Glader.ASP.RPG.TestRaceType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("race");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            VisualName = "Human"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            VisualName = "Orc"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGSItemSubClass<Glader.ASP.RPG.TestItemClass>", b =>
                {
                    b.Property<int>("ItemClassId")
                        .HasColumnType("int");

                    b.Property<int>("SubClassId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ItemClassId", "SubClassId");

                    b.ToTable("item_sub_class");
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGSkill<Glader.ASP.RPG.TestSkillType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsPassiveSkill")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("skill");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            IsPassiveSkill = false,
                            VisualName = "Woodcutting"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            IsPassiveSkill = false,
                            VisualName = "Mining"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            IsPassiveSkill = false,
                            VisualName = "Firemaking"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            IsPassiveSkill = false,
                            VisualName = "Parry"
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGStat<Glader.ASP.RPG.TestStatType>", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VisualName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("stat");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            VisualName = "Strength"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            VisualName = "Intellect"
                        });
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterDefinition<Glader.ASP.RPG.TestRaceType, Glader.ASP.RPG.TestClassType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGClass<Glader.ASP.RPG.TestClassType>", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGRace<Glader.ASP.RPG.TestRaceType>", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterItemInventory<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGItemInstanceOwnership<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", "ItemOwnership")
                        .WithMany()
                        .HasForeignKey("OwnershipId", "OwnershipType")
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterProgress", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithOne("Progress")
                        .HasForeignKey("Glader.ASP.RPG.DBRPGCharacterProgress", "Id")
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

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterSkillKnown<Glader.ASP.RPG.TestSkillType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGSkill<Glader.ASP.RPG.TestSkillType>", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterSkillLevel<Glader.ASP.RPG.TestSkillType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGSkill<Glader.ASP.RPG.TestSkillType>", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGCharacterSkillKnown<Glader.ASP.RPG.TestSkillType>", "KnownSkill")
                        .WithOne("SkillLevelData")
                        .HasForeignKey("Glader.ASP.RPG.DBRPGCharacterSkillLevel<Glader.ASP.RPG.TestSkillType>", "CharacterId", "SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGCharacterStatDefault<Glader.ASP.RPG.TestStatType, Glader.ASP.RPG.TestRaceType, Glader.ASP.RPG.TestClassType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGClass<Glader.ASP.RPG.TestClassType>", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGRace<Glader.ASP.RPG.TestRaceType>", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("Glader.ASP.RPG.RPGStatValue<Glader.ASP.RPG.TestStatType>", "Stats", b1 =>
                        {
                            b1.Property<int>("Level")
                                .HasColumnType("int");

                            b1.Property<int>("Race")
                                .HasColumnType("int");

                            b1.Property<int>("ClassId")
                                .HasColumnType("int");

                            b1.Property<int>("StatType")
                                .HasColumnType("int");

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("Level", "Race", "ClassId", "StatType");

                            b1.HasIndex("StatType");

                            b1.ToTable("RPGStatValue<TestStatType>");

                            b1.HasOne("Glader.ASP.RPG.DBRPGStat<Glader.ASP.RPG.TestStatType>", "Stat")
                                .WithMany()
                                .HasForeignKey("StatType")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("Level", "Race", "ClassId");
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGGroupMember", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGGroup", "Group")
                        .WithMany("Members")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemInstance<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGItemTemplate<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemInstanceOwnership<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGItemInstance<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", "Instance")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGItemTemplate<Glader.ASP.RPG.TestItemClass, Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGQuality<Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", "Quality")
                        .WithMany()
                        .HasForeignKey("QualityType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Glader.ASP.RPG.DBRPGSItemSubClass<Glader.ASP.RPG.TestItemClass>", "ItemSubClass")
                        .WithMany()
                        .HasForeignKey("ClassId", "SubClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGQuality<Glader.ASP.RPG.TestQualityType, Glader.ASP.RPG.TestColorType>", b =>
                {
                    b.OwnsOne("Glader.ASP.RPG.TestColorType", "Color", b1 =>
                        {
                            b1.Property<int>("DBRPGQuality<TestQualityType, TestColorType>Id")
                                .HasColumnType("int");

                            b1.Property<int>("B")
                                .HasColumnType("int");

                            b1.Property<int>("G")
                                .HasColumnType("int");

                            b1.Property<int>("R")
                                .HasColumnType("int");

                            b1.HasKey("DBRPGQuality<TestQualityType, TestColorType>Id");

                            b1.ToTable("quality");

                            b1.WithOwner()
                                .HasForeignKey("DBRPGQuality<TestQualityType, TestColorType>Id");
                        });
                });

            modelBuilder.Entity("Glader.ASP.RPG.DBRPGSItemSubClass<Glader.ASP.RPG.TestItemClass>", b =>
                {
                    b.HasOne("Glader.ASP.RPG.DBRPGItemClass<Glader.ASP.RPG.TestItemClass>", "ItemClass")
                        .WithMany("SubClasses")
                        .HasForeignKey("ItemClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
