using System.Collections.Generic;

namespace TrieLib {

	/// <summary>
	/// Represents a single character in a string as stored in a Trie data structure.
	/// Holds references to any further Child nodes that continue to make up a string we have stored.
	/// </summary>
	public class Node {
		public char Value { get; set; }
		public List<Node> Children { get; set; }
		public Node Parent { get; set; }
		public int Depth { get; set; }

		public Node(char value, int depth, Node parent) {
			Value = value;
			Children = new List<Node>();
			Depth = depth;
			Parent = parent;
		}

		public Node FindChildNode(char c) {
			foreach (Node child in Children) {
				if (child.Value == c) return child;
			}
			return null;
		}
	}
}
