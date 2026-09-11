using System.Collections.Generic;

namespace COW;

public class TailorSeriesData
{
	public uint tailorId;

	public List<uint> sets;

	public Dictionary<int, List<uint>> cloths;

	public TailorSeriesData(uint id, bool isSet = false)
	{
	}
}
