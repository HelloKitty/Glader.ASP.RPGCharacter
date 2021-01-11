﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Glader
{
	/// <summary>
	/// Database table model that represents an ownership relationship
	/// for a character.
	/// </summary>
	[Table("character_customization_slot_type")]
	public class DBRPGCharacterCustomizableSlot<TCustomizableSlotType>
		where TCustomizableSlotType : Enum
	{
		/// <summary>
		/// The primary key (enumerated slot type).
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public TCustomizableSlotType SlotType { get; private set; }

		/// <summary>
		/// The visual human-readable name for the slot.
		/// </summary>
		public string VisualName { get; private set; }

		/// <summary>
		/// The description of the slot.
		/// </summary>
		public string Description { get; private set; }

		public DBRPGCharacterCustomizableSlot(TCustomizableSlotType slotType, string visualName, string description)
		{
			SlotType = slotType ?? throw new ArgumentNullException(nameof(slotType));
			VisualName = visualName;
			Description = description;
		}

		public DBRPGCharacterCustomizableSlot(TCustomizableSlotType slotType)
		{
			SlotType = slotType ?? throw new ArgumentNullException(nameof(slotType));
			VisualName = String.Empty;
			Description = String.Empty;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public DBRPGCharacterCustomizableSlot()
		{
			
		}
	}
}
