﻿using System;
using System.Linq;

namespace Fives.Gameplay
{
	public class ValidWord
	{
		public bool WordIsValid(string word)
		{
			if (word.Length != 5)
				return false;

			if (word.Distinct().Count() != 5)
				return false;

			return true;
		}
	}
}