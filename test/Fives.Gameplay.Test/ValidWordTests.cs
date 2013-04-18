using System;
using Xunit;

namespace Fives.Gameplay.Test
{
	public class ValidWordTests
	{
		[Fact]
		public void ValidWord_FiveCharacters_IsValid()
		{
			ValidWord guess = new ValidWord();
			Assert.True(guess.WordIsValid("abcde"));
		}

		[Fact]
		public void ValidWord_LessThanFiveCharacters_IsInValid()
		{
			ValidWord guess = new ValidWord();
			Assert.False(guess.WordIsValid("abcd"));
		}

		[Fact]
		public void ValidWord_MoreThanFiveCharacters_IsInValid()
		{
			ValidWord guess = new ValidWord();
			Assert.False(guess.WordIsValid("abcdef"));
		}

		[Fact]
		public void ValidWord_OnlyFiveDistinctCharacters_IsValid()
		{
			ValidWord guess = new ValidWord();
			Assert.False(guess.WordIsValid("aaaaa"));
			Assert.False(guess.WordIsValid("aaaab"));
			Assert.False(guess.WordIsValid("aaabc"));
			Assert.False(guess.WordIsValid("aabcd"));
		}
	}
}