﻿using StationAutoComplete.Models;

namespace StationAutoComplete.Services {
	public interface IStationFinder {
		Suggestions GetSuggestions(string userInput);
	}
}
