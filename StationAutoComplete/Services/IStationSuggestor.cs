using StationAutoComplete.Models;

namespace StationAutoComplete.Services {
	public interface IStationSuggestor {
		Suggestions GetSuggestions(string prefix);
	}
}
