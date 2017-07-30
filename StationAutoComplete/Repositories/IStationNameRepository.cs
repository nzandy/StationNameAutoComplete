using System.Collections.Generic;

namespace StationAutoComplete.Repositories {
	public interface IStationNameRepository {
		IEnumerable<string> GetStationNames();
	}
}
