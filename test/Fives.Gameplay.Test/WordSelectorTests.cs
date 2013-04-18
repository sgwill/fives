using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fives.Gameplay.Test
{
	public class WordSelectorTests
	{
		[Fact]
		public void WordList_EmptyList_ReturnsEmpty()
		{
			WordSelector wordSelector = new WordSelector();
			var selectedWord = wordSelector.SelectWord(new List<string>());
			Assert.Equal("", selectedWord);
		}

		[Fact]
		public void SelectedWord_SelectsWordFromList()
		{
			WordSelector wordSelector = new WordSelector();
			var selectedWord = wordSelector.SelectWord(new List<string> { "bread", "apple" });
			Assert.NotNull(selectedWord);
		}

        [Fact]
        public void WordList_IgnoresCase()
        {
			WordSelector wordSelector = new WordSelector();
			var selectedWord = wordSelector.SelectWord(new List<string> { "bread" });
            Assert.Equal("BREAD", selectedWord);
        }
 
        [Fact]
        public void WordList_OnlyAcceptsFiveLetters()
        {
			WordSelector wordSelector = new WordSelector();
			var selectedWord = wordSelector.SelectWord(new List<string> { "bread", "take", "maples" });
            Assert.Equal("BREAD", selectedWord);
        }

		[Fact]
		public void SelectedWord_DoesNotContainMultipleLetters()
		{
			WordSelector wordSelector = new WordSelector();
			var selectedWord = wordSelector.SelectWord(new List<string> { "apple", "bread" });
			Assert.Equal("BREAD", selectedWord);
		}
	}
}