﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Glader.ASP.RPGCharacter
{
	public sealed class RPGCharacterDatabaseContext : DbContext
	{
		/// <summary>
		/// The character table.
		/// </summary>
		public DbSet<DBRPGCharacter> Characters { get; set; }

		/// <summary>
		/// The ownership relationship of characters.
		/// </summary>
		public DbSet<DBRPGCharacterOwnership> CharacterOwnership { get; set; }

		public RPGCharacterDatabaseContext(DbContextOptions<RPGCharacterDatabaseContext> options)
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

			modelBuilder.Entity<DBRPGCharacterProgress>(builder =>
			{
				builder.Property(c => c.PlayTime)
					.HasDefaultValue(TimeSpan.Zero);
			});
		}
	}
}