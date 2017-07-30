using StationAutoComplete.Repositories;

namespace StationAutoComplete.Services {
	public class StationFinder : IStationFinder {

		private IStationSuggestor _suggestor;

		public StationFinder(IStationNameRepository stationRepo) {
			_suggestor = new TrieStationSuggestor(stationRepo);

		}

		public Suggestions GetSuggestions(string userInput) {
			return _suggestor.GetStationSuggestions(userInput);
		}
	}
}
