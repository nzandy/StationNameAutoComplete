using System.Collections.Generic;
using TrieLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrieLibTests {

	[TestClass]
	public class TrieGetAutoCompletionsTests {
		private Trie _trie;
		private static List<string> storedStrings = new List<string> {
			"dog",
			"horse",
			"cat",
			"catch",
			"car",
			"ABC"
		};

		[TestInitialize]
		public void Setup() {
			_trie = new Trie();
			_trie.InsertRange(storedStrings);
		}
		[TestMethod]
		public void MultipleCompletionsContainCorrectElements() {
			List<string> completions = _trie.GetAutoCompletions("ca");
			Assert.AreEqual(3, completions.Count);
			Assert.IsTrue(completions.Contains("cat"));
			Assert.IsTrue(completions.Contains("catch"));
			Assert.IsTrue(completions.Contains("car"));
		}

		[TestMethod]
		public void CompletionsShouldBeCaseSensitive() {
			List<string> completions = _trie.GetAutoCompletions("CA");
			Assert.AreEqual(0, completions.Count);
		}

		[TestMethod]
		public void PrefixMatchesEntryReturnsEntry() {
			List<string> completions = _trie.GetAutoCompletions("dog");
			Assert.AreEqual(1, completions.Count);
			Assert.IsTrue(completions.Contains("dog"));
		}
	}
}
