using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StationAutoComplete.Services;
using StationAutoComplete.Repositories;

namespace StationAutoCompleteTests {
	[TestClass]
	public class StationFinderTests {
		[TestMethod]
		public void CheckResults() {
			var stationRepo = new HardcodedStationNameRepository();
			var stations = stationRepo.GetStationNames();
			var stationFinderService = new StationFinder(stationRepo);
			var results = stationFinderService.GetSuggestions("D");
		}
	}
}
