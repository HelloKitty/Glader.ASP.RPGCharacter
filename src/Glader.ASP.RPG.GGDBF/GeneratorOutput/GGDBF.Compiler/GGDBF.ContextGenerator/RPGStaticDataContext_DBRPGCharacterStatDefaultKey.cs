﻿using Glader.ASP.RPG;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Runtime.Serialization;
using GGDBF;

namespace Glader.ASP.RPG
{
    [GeneratedCodeAttribute("GGDBF", "0.0.27.0")]
    public record DBRPGCharacterStatDefaultKey<TStatType, TRaceType, TClassType>(System.Int32 Level, TRaceType RaceId, TClassType ClassId);
}