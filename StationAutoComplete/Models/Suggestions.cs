using System.Collections.Generic;

namespace StationAutoComplete {

	public class Suggestions {
		public List<char> NextLetters { get; set; }
		public IEnumerable<string> Stations { get; set; }
	}
}
