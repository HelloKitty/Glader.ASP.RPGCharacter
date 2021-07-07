﻿using System;
using System.Collections.Generic;
using GGDBF;

namespace Glader.ASP.RPG
{
	[RequiredDataModel(typeof(DBRPGSkill<>))]
	[RequiredDataModel(typeof(DBRPGRace<>))]
	[RequiredDataModel(typeof(DBRPGClass<>))]
	[RequiredDataModel(typeof(DBRPGCharacterCustomizableSlotType<>))]
	[RequiredDataModel(typeof(DBRPGCharacterProportionSlotType<>))]
	[RequiredDataModel(typeof(DBRPGStat<>))]
	[RequiredDataModel(typeof(DBRPGCharacterStatDefault<,,>))]
	[RequiredDataModel(typeof(DBRPGItemClass<>))]
	[RequiredDataModel(typeof(DBRPGSItemSubClass<>))]
	public partial class RPGStaticDataContext<TSkillType, TRaceType, TClassType, TProportionSlotType, TCustomizableSlotType, TStatType, TItemClassType> 
		where TSkillType : Enum 
		where TRaceType : Enum
		where TClassType : Enum
		where TCustomizableSlotType : Enum
		where TProportionSlotType : Enum
		where TStatType : Enum
		where TItemClassType : Enum
	{
		public IReadOnlyDictionary<TSkillType, DBRPGSkill<TSkillType>> Skill { get; init; }

		public IReadOnlyDictionary<TRaceType, DBRPGRace<TRaceType>> Race { get; init; }

		public IReadOnlyDictionary<TClassType, DBRPGClass<TClassType>> @Class { get; init; }

		public IReadOnlyDictionary<TCustomizableSlotType, DBRPGCharacterCustomizableSlotType<TCustomizableSlotType>> CharacterCustomizationSlotType { get; init; }

		public IReadOnlyDictionary<TProportionSlotType, DBRPGCharacterProportionSlotType<TProportionSlotType>> CharacterProportionSlotType { get; init; }

		public IReadOnlyDictionary<TStatType, DBRPGStat<TStatType>> Stat { get; init; }

		public IReadOnlyDictionary<DBRPGCharacterStatDefaultKey<TStatType, TRaceType, TClassType>, DBRPGCharacterStatDefault<TStatType, TRaceType, TClassType>> CharacterStatDefault { get; init; }

		public IReadOnlyDictionary<TItemClassType, DBRPGItemClass<TItemClassType>> ItemClass { get; init; }

		public IReadOnlyDictionary<DBRPGSItemSubClassKey<TItemClassType>, DBRPGSItemSubClass<TItemClassType>> ItemSubClass { get; init; }
	}
}
