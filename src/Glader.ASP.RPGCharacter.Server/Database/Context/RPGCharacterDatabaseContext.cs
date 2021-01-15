﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Glader.ASP.RPGCharacter
{
	public abstract class RPGCharacterDatabaseContext : DbContext
	{
		/// <summary>
		/// The character table.
		/// </summary>
		public DbSet<DBRPGCharacter> Characters { get; set; }

		/// <summary>
		/// The ownership relationship of characters.
		/// </summary>
		public DbSet<DBRPGCharacterOwnership> CharacterOwnership { get; set; }

		protected RPGCharacterDatabaseContext(DbContextOptions<RPGCharacterDatabaseContext> options)
			: base(options)
		{

		}

		protected RPGCharacterDatabaseContext(DbContextOptions options)
			: base(options)
		{

		}

		protected RPGCharacterDatabaseContext()
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<DBRPGCharacterProgress>(builder =>
			{
				builder.Property(c => c.PlayTime)
					.HasDefaultValue(TimeSpan.Zero);
			});

			modelBuilder.Entity<DBRPGCharacterOwnership>(builder =>
			{
				//index by owner since we will query character lists and such.
				builder.HasIndex(c => c.OwnershipId);

				//Builds a composite key between the owner and characterid.
				//EF Requires keys, keyless entities are second class citizens.
				builder.HasKey(c => new { c.OwnershipId, c.CharacterId });
			});
		}
	}

	public sealed class RPGCharacterDatabaseContext<TCustomizableSlotType, TColorStructureType, TProportionSlotType, TProportionStructureType> : RPGCharacterDatabaseContext
		where TCustomizableSlotType : Enum
		where TProportionSlotType : Enum
	{
		/// <summary>
		/// The customized slots for the character.
		/// </summary>
		public DbSet<DBRPGCharacterCustomizableSlot<TCustomizableSlotType, TColorStructureType>> CustomizableSlots { get; set; }

		/// <summary>
		/// The customizable slot types supported.
		/// </summary>
		public DbSet<DBRPGCharacterCustomizableSlotType<TCustomizableSlotType>> CustomizableSlotTypes { get; set; }

		/// <summary>
		/// The customized slots for the character.
		/// </summary>
		public DbSet<DBRPGCharacterProportionSlot<TProportionSlotType, TProportionStructureType>> ProportionSlots { get; set; }

		/// <summary>
		/// The customizable slot types supported.
		/// </summary>
		public DbSet<DBRPGCharacterProportionSlotType<TProportionSlotType>> ProportionSlotTypes { get; set; }

		public RPGCharacterDatabaseContext(DbContextOptions<RPGCharacterDatabaseContext<TCustomizableSlotType, TColorStructureType, TProportionSlotType, TProportionStructureType>> options)
			: base(options)
		{

		}

		public RPGCharacterDatabaseContext()
		{

		}

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<DBRPGCharacterCustomizableSlot<TCustomizableSlotType, TColorStructureType>>(builder =>
			{
				builder.HasOne<DBRPGCharacter>()
					.WithMany()
					.HasForeignKey(c => c.CharacterId);

				builder.HasIndex(c => c.CharacterId);
				builder.HasKey(c => new {c.CharacterId, c.SlotType});

				if (!typeof(TColorStructureType).IsPrimitive)
				{
					//TODO: A total hack, but it must be a reference type if we make it Owned.
					Expression<Func<DBRPGCharacterCustomizableSlot<TCustomizableSlotType, TColorStructureType>, TColorStructureType>> expression = c => c.SlotColor;
					((dynamic)builder).OwnsOne(expression);
				}
			});

			//Seed the DB with the available enum entries.
			modelBuilder.Entity<DBRPGCharacterCustomizableSlotType<TCustomizableSlotType>>().HasData(
				((TCustomizableSlotType[]) Enum.GetValues(typeof(TCustomizableSlotType)))
				.Select(v => new DBRPGCharacterCustomizableSlotType<TCustomizableSlotType>(v, v.ToString(), String.Empty))
				.ToArray()
			);

			modelBuilder.Entity<DBRPGCharacterProportionSlot<TProportionSlotType, TProportionStructureType>>(builder =>
			{
				builder.HasOne<DBRPGCharacter>()
					.WithMany()
					.HasForeignKey(c => c.CharacterId);

				builder.HasIndex(c => c.CharacterId);
				builder.HasKey(c => new { c.CharacterId, c.SlotType });

				if(!typeof(TProportionStructureType).IsPrimitive)
				{
					//TODO: A total hack, but it must be a reference type if we make it Owned.
					Expression<Func<DBRPGCharacterProportionSlot<TProportionSlotType, TProportionStructureType>, TProportionStructureType>> expression = c => c.Proportion;
					((dynamic)builder).OwnsOne(expression);
				}
			});

			//Seed the DB with the available enum entries.
			modelBuilder.Entity<DBRPGCharacterProportionSlotType<TProportionSlotType>>().HasData(
				((TProportionSlotType[])Enum.GetValues(typeof(TProportionSlotType)))
				.Select(v => new DBRPGCharacterProportionSlotType<TProportionSlotType>(v, v.ToString(), String.Empty))
				.ToArray()
			);
		}
	}
}
