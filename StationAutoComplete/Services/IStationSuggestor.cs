namespace StationAutoComplete.Services {
	public interface IStationSuggestor {
		Suggestions GetStationSuggestions(string prefix);
	}
}
