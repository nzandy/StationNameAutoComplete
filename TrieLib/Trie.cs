using System.Collections.Generic;
using System.Text;

namespace TrieLib {

	/// <summary>
	/// A search tree data structure that is optimal for quick retrieval of strings.
	/// Each node in the tree represents a character in a word/string we have stored.
	/// Each node contains references to any children nodes (next letters in the string or end tokens).
	/// </summary>
	public class Trie {
		private const char WORD_COMPLETION_CHAR = '$';
		private const char ROOT_NODE_CHAR = '^';
		private readonly Node _root;

		public Trie() {
			_root = new Node(ROOT_NODE_CHAR, 0, null);
		}

		/// <summary>
		/// Traverses the Trie structure to find the Node represented by the string passed in.
		/// </summary>
		/// <param name="s">The prefix string to search for.</param>
		/// <returns></returns>
		public Node FindPrefixNode(string s) {
			Node currentNode = _root;
			Node result = currentNode;
			foreach (char c in s) {
				currentNode = currentNode.FindChildNode(c);
				if (currentNode == null) {
					break;
				}
				result = currentNode;
			}
			return result;
		}

		/// <summary>
		/// Return all strings that begin with the given prefix.
		/// </summary>
		public List<string> GetAutoCompletions(string prefix) {
			Node matchedNode = FindPrefixNode(prefix);
			List<string> completions = new List<string>();

			// No matches found
			if (matchedNode == null || matchedNode.Value == ROOT_NODE_CHAR) {
				return completions;
			}
			StringBuilder autoCompletionBuilder = new StringBuilder(prefix);
			GetAutoCompletionsRecursive(matchedNode, autoCompletionBuilder, completions);
			return completions;
		}

		// Conducts depth first traversal of all words in our Trie that begin with the given prefix.
		private void GetAutoCompletionsRecursive(Node currentNode, StringBuilder autoCompletionBuilder, List<string> completions) {

			// We have reached the end of a word, add it to our auto complete collection.
			if (currentNode.Value == WORD_COMPLETION_CHAR) {
				autoCompletionBuilder.Length -= 1;
				completions.Add(autoCompletionBuilder.ToString());
				return;
			}

			if (currentNode.Children != null) {
				foreach (Node node in currentNode.Children) {
					autoCompletionBuilder.Append(node.Value);
					GetAutoCompletionsRecursive(node, autoCompletionBuilder, completions);
				}
			}
			// When we have finished one word, we backtrack up the tree and as we do so we 
			// remove each char value from our current stringbuilder.
			autoCompletionBuilder.Length -= 1;
		}

		// Add a collection of strings to our Trie data structure.
		public void InsertRange(IEnumerable<string> items) {
			foreach (string s in items) {
				Insert(s);
			}
		}

		/// <summary>
		/// Finds a common prefix in the Trie and then adds any extra characters not included from our new string.
		/// </summary>
		/// <param name="s">The string to add to the Trie.</param>
		public void Insert(string s) {
			Node commonPrefix = FindPrefixNode(s);
			if (commonPrefix == null) {
				commonPrefix = _root;
			}
			Node current = commonPrefix;

			for (var i = current.Depth; i < s.Length; i++) {
				var newNode = new Node(s[i], current.Depth + 1, current);
				current.Children.Add(newNode);
				current = newNode;
			}
			// Add a terminating leaf node to mark end of string.
			current.Children.Add(new Node('$', current.Depth + 1, current));
		}
	}
}
