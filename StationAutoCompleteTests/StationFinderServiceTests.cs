using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using StationAutoComplete.Services;
using StationAutoCompleteTests.Mocks;
using StationAutoComplete.Models;

namespace StationAutoCompleteTests {
	[TestClass]
	public class StationFinderServiceTests {
		private StationFinderService _stationFinderService;

		[TestInitialize]
		public void Setup() {
			var repo = new MockStationNameRepository();
			var stationFinderService = new StationFinderService(repo);
			_stationFinderService = stationFinderService;
		}

		[TestMethod]
		public void GetSuggestionsShouldReturnStationMatches() {
			Suggestions suggestions = _stationFinderService.GetSuggestions("DART");
			Assert.IsTrue(suggestions.Stations.Contains("DARTFORD"));
			Assert.IsTrue(suggestions.Stations.Contains("DARTON"));
		}

		[TestMethod]
		public void GetSuggestionsShouldNotReturnNonMatches() {
			Suggestions suggestions = _stationFinderService.GetSuggestions("DART");
			Assert.IsFalse(suggestions.Stations.Contains("DORKING"));
			Assert.IsFalse(suggestions.Stations.Contains("CORBY"));
		}

		[TestMethod]
		public void GetSuggestionsShouldReturnNextLetters() {
			Suggestions suggestions = _stationFinderService.GetSuggestions("DART");
			Assert.IsTrue(suggestions.NextLetters.Contains('F'));
			Assert.IsTrue(suggestions.NextLetters.Contains('O'));
		}

		[TestMethod]
		public void GetSuggestionsStationsShouldBeCaseInsensitive() {
			Suggestions suggestions = _stationFinderService.GetSuggestions("dart");
			Assert.IsTrue(suggestions.Stations.Contains("DARTFORD"));
			Assert.IsTrue(suggestions.Stations.Contains("DARTON"));
		}

		[TestMethod]
		public void GetSuggestionsShouldReturnNextLettersCaseInsensitive() {
			Suggestions suggestions = _stationFinderService.GetSuggestions("dart");
			Assert.IsTrue(suggestions.NextLetters.Contains('F'));
			Assert.IsTrue(suggestions.NextLetters.Contains('O'));
		}
	}
}
