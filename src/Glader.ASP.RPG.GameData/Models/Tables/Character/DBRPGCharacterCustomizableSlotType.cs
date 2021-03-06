﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace Glader.ASP.RPG
{
	/// <summary>
	/// The character customization slot type.
	/// </summary>
	[DataContract]
	[Table("character_customization_slot_type")]
	public class DBRPGCharacterCustomizableSlotType<TCustomizableSlotType> : ICharacterSlotTypeDefinition<TCustomizableSlotType>
		where TCustomizableSlotType : Enum
	{
		/// <summary>
		/// The primary key (enumerated slot type).
		/// </summary>
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		[DataMember(Order = 1)]
		public TCustomizableSlotType SlotType { get; private set; }

		/// <summary>
		/// The visual human-readable name for the slot.
		/// </summary>
		[DataMember(Order = 2)]
		public string VisualName { get; private set; }

		/// <summary>
		/// The description of the slot.
		/// </summary>
		[DataMember(Order = 3)]
		public string Description { get; private set; }

		public DBRPGCharacterCustomizableSlotType(TCustomizableSlotType slotType, string visualName, string description)
		{
			SlotType = slotType ?? throw new ArgumentNullException(nameof(slotType));
			VisualName = visualName;
			Description = description;
		}

		public DBRPGCharacterCustomizableSlotType(TCustomizableSlotType slotType)
		{
			SlotType = slotType ?? throw new ArgumentNullException(nameof(slotType));
			VisualName = String.Empty;
			Description = String.Empty;
		}

		/// <summary>
		/// Serializer ctor.
		/// </summary>
		public DBRPGCharacterCustomizableSlotType()
		{
			
		}
	}
}
