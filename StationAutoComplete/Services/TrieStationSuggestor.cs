using System;
using StationAutoComplete.Repositories;

namespace StationAutoComplete.Services {
	public class TrieStationSuggestor : IStationSuggestor {
		private IStationNameRepository _stationRepo;

		public TrieStationSuggestor(IStationNameRepository stationRepo) {
			_stationRepo = stationRepo;
		}

		public Suggestions GetStationSuggestions(string prefix) {
			throw new NotImplementedException();
		}
	}
}
