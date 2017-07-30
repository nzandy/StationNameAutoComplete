using StationAutoComplete.Repositories;
using StationAutoComplete.Models;
using System.Collections.Generic;

namespace StationAutoComplete.Services {

	/// <summary>
	/// Given a repository of Train station names, the StationFinderService can be used to
	/// retrieve autocomplete suggestions when given a prefix.
	/// </summary>
	public class StationFinderService : IStationFinder {

		private IStationSuggestor _suggestor;
		private Dictionary<string, Suggestions> _cachedSuggestions;

		public StationFinderService(IStationNameRepository stationRepo) {
			_suggestor = new TrieStationSuggestor(stationRepo);
			_cachedSuggestions = new Dictionary<string, Suggestions>();
		}

		public Suggestions GetSuggestions(string input) {
			Suggestions suggestions;
			input = input.ToUpper();

			// If we have seen this request before, return cached data instead.
			if (_cachedSuggestions.TryGetValue(input, out suggestions)) {
				return suggestions;
			}

			suggestions = _suggestor.GetSuggestions(input);
			_cachedSuggestions.Add(input, suggestions);
			return suggestions;
		}
	}
}
