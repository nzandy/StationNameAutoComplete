using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TrieLib;

namespace TrieLibTests {
	[TestClass]
	public class TrieFindPrefixTests {
		private Trie _trie;
		private static List<string> storedStrings = new List<string> {
			"dog",
			"horse",
			"cat",
			"ABC"
		};

		[TestInitialize]
		public void Setup() {
			_trie = new Trie();
			_trie.InsertRange(storedStrings);
		}

		[TestMethod]
		public void NotFoundStringReturnsRootNode() {
			Node node = _trie.FindPrefixNode("zzz");
			Assert.AreEqual('^', node.Value);
		}

		[TestMethod]
		public void FoundStringReturnsEndCharacterNode() {
			Node node = _trie.FindPrefixNode("dog");
			Assert.AreEqual('g', node.Value);
		}

		[TestMethod]
		public void FoundStringReturnsCorrectDepth() {
			Node node = _trie.FindPrefixNode("horse");
			Assert.AreEqual(5, node.Depth);
		}

		[TestMethod]
		public void TrieSearchShouldBeCaseSensitive() {
			Node node = _trie.FindPrefixNode("DOG");
			Assert.AreEqual('^', node.Value);
		}
	}
}
