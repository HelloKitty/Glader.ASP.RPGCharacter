﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Glader.Essentials;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Glader.ASP.RPGCharacter
{
	public static class IMvcBuilderExtensions
	{
		/// <summary>
		/// Registers the general <see cref="CharacterDataController"/> with the MVC
		/// controllers. See controller documentation for what it does and how it works.
		/// </summary>
		/// <param name="builder"></param>
		/// <returns></returns>
		public static IMvcBuilder RegisterCharacterDataController<TCustomizableSlotType, TColorStructureType, TProportionSlotType, TProportionStructureType>(this IMvcBuilder builder) 
			where TCustomizableSlotType : Enum 
			where TProportionSlotType : Enum
		{
			if(builder == null) throw new ArgumentNullException(nameof(builder));

			return builder
				.RegisterController<CharacterDataController>()
				.RegisterController<CharacterAppearanceController<TCustomizableSlotType, TColorStructureType, TProportionSlotType, TProportionStructureType>>();
		}
	}
}
