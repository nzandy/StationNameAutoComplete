using System.Collections.Generic;

namespace StationAutoComplete.Models {

	public class Suggestions {
		public IEnumerable<char> NextLetters { get; set; }
		public IEnumerable<string> Stations { get; set; }
	}
}
