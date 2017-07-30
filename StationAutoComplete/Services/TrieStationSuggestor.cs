using System.Linq;
using StationAutoComplete.Models;
using StationAutoComplete.Repositories;
using TrieLib;
using System.Collections.Generic;

namespace StationAutoComplete.Services {
	public class TrieStationSuggestor : IStationSuggestor {
		private Trie _stationNameTrie;

		public TrieStationSuggestor(IStationNameRepository stationRepo) {
			_stationNameTrie = new Trie();
			_stationNameTrie.InsertRange(stationRepo.GetStationNames());
		}

		public Suggestions GetSuggestions(string prefix) {
			var suggestions = new Suggestions();
			List<string> autoCompletions = GetAutoCompleteStations(prefix).ToList();
			if (autoCompletions.Any()) {
				suggestions.Stations = autoCompletions;
				suggestions.NextLetters = GetNextLetterSuggestions(prefix);
			}
			return suggestions;
		}

		private IEnumerable<string> GetAutoCompleteStations(string prefix) {
			return _stationNameTrie.GetAutoCompletions(prefix);
		}

		private IEnumerable<char> GetNextLetterSuggestions(string prefix) {
			Node prefixNode = _stationNameTrie.FindPrefixNode(prefix);
			return prefixNode.Children.Select(c => c.Value);
		}
	}
}
