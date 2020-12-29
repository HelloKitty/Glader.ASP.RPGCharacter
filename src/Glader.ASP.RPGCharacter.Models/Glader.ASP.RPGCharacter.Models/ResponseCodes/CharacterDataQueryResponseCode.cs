﻿using System;
using System.Collections.Generic;
using System.Text;
using Glader.Essentials;

namespace Glader.ASP.RPGCharacter
{
	/// <summary>
	/// Enumerations of data query response codes.
	/// </summary>
	public enum CharacterDataQueryResponseCode
	{
		Success = GladerEssentialsModelConstants.RESPONSE_CODE_SUCCESS_VALUE,

		/// <summary>
		/// General/unknown error in query.
		/// </summary>
		GeneralError = 1,

		/// <summary>
		/// The character data is data not authorized to query.
		/// </summary>
		NotAuthorized = 2,

		/// <summary>
		/// The requested character does not exist.
		/// </summary>
		CharacterDoesNotExist = 3,
	}
}
