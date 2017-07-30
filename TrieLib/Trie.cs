using System.Collections.Generic;
using System.Text;

namespace TrieLib {
	public class Trie {
		private const char WORD_COMPLETION_CHAR = '$';
		private readonly Node _root;

		public Trie() {
			_root = new Node('^', 0, null);
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

		public bool Search(string s) {
			Node prefix = FindPrefixNode(s);
			return prefix.Depth == s.Length && prefix.FindChildNode(WORD_COMPLETION_CHAR) != null;
		}

		public List<string> GetAutoCompletions(string prefix) {
			Node matchedNode = FindPrefixNode(prefix);
			List<string> completions = new List<string>();
			StringBuilder autoCompletionBuilder = new StringBuilder(prefix);
			GetAutoCompletionsRecursive(matchedNode, autoCompletionBuilder, completions);
			return completions;
		}

		private void GetAutoCompletionsRecursive(Node currentNode, StringBuilder autoCompletionBuilder, List<string> completions) {
			if (currentNode == null) {
				autoCompletionBuilder.Length -= 1;
			}

			if (currentNode.Value == WORD_COMPLETION_CHAR) {
				completions.Add(autoCompletionBuilder.ToString());
			}

			if (currentNode.Children != null) {
				foreach (Node node in currentNode.Children) {
					if (node.Value != WORD_COMPLETION_CHAR) {
						autoCompletionBuilder.Append(node.Value);
					}
					GetAutoCompletionsRecursive(node, autoCompletionBuilder, completions);
				}
			}
			autoCompletionBuilder.Length -= 1;
		}

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
			Node current = commonPrefix;

			for (var i = current.Depth; i < s.Length; i++) {
				var newNode = new Node(s[i], current.Depth + 1, current);
				current.Children.Add(newNode);
				current = newNode;
			}
			// Add a terminating leaf node to mark end of string.
			current.Children.Add(new Node('$', current.Depth + 1, current));
		}

		public void Delete(string s) {
			if (Search(s)) {
				// Because we know s exists in the trie, the common prefix will actually be the entire string we want to remove.
				Node node = FindPrefixNode(s).FindChildNode('$');
				while (node.IsLeaf()) {
					Node parent = node.Parent;
					parent.DeleteChildNode(node.Value);
					node = parent;
				}
			}
		}
	}
}
