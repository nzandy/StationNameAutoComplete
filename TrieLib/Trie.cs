using System.Collections.Generic;

namespace TrieLib {
	public class Trie {
		private readonly Node _root;

		public Trie() {
			_root = new Node('^', 0, null);
		}

		public Node FindCommonPrefixNode(string s) {
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
			Node prefix = FindCommonPrefixNode(s);
			return prefix.Depth == s.Length && prefix.FindChildNode('$') != null;
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
			Node commonPrefix = FindCommonPrefixNode(s);
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
				Node node = FindCommonPrefixNode(s).FindChildNode('$');
				while (node.IsLeaf()) {
					Node parent = node.Parent;
					parent.DeleteChildNode(node.Value);
					node = parent;
				}
			}
		}
	}
}
