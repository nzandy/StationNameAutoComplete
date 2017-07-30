using System;
using System.Collections.Generic;
using StationAutoComplete.Repositories;

namespace StationAutoCompleteTests.Mocks {
	public class MockStationNameRepository : IStationNameRepository {
		private static List<string> _stationNames = new List<string> {
			"Dartford",
			"Darton",
			"Dorking",
			"Corby"
		};
		public IEnumerable<string> GetStationNames() {
			return _stationNames;
		}
	}
}
