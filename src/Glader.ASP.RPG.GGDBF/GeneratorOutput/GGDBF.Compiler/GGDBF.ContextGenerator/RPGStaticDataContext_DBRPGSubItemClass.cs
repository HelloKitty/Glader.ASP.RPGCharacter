﻿using Glader.ASP.RPG;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;
using GGDBF;

namespace Glader.ASP.RPG
{
    [GeneratedCodeAttribute("GGDBF", "0.1.35.0")]
    [DataContractAttribute]
    public partial class RPGStaticDataContext_DBRPGSubItemClass<TSkillType, TRaceType, TClassType, TProportionSlotType, TCustomizableSlotType, TStatType, TItemClassType> : DBRPGSubItemClass<TItemClassType>, IGGDBFSerializable where TSkillType : System.Enum
       where TRaceType : System.Enum
       where TClassType : System.Enum
       where TProportionSlotType : System.Enum
       where TCustomizableSlotType : System.Enum
       where TStatType : System.Enum
       where TItemClassType : System.Enum
    {
        [IgnoreDataMemberAttribute]
        public override Glader.ASP.RPG.DBRPGItemClass<TItemClassType> ItemClass
        {
            get => RPGStaticDataContext<TSkillType, TRaceType, TClassType, TProportionSlotType, TCustomizableSlotType, TStatType, TItemClassType>.Instance.ItemClass[base.ItemClassId];
        }
        public RPGStaticDataContext_DBRPGSubItemClass() { }

        public void Initialize(IGGDBFDataConverter converter)
        {
        }
    }
}