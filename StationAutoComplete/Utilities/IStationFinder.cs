namespace StationAutoComplete.Utilities {
	public interface IStationFinder {
		Suggestions GetSuggestions(string userInput);
	}
}
