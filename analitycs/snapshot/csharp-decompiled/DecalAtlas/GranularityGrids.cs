using System;

namespace DecalAtlas;

[Serializable]
public class GranularityGrids
{
	public int Granularities;

	private GridForGranularity[] _PersistGrids;

	[NonSerialized]
	public GridForGranularity[] RuntimeGrids;

	public void Load()
	{
	}
}
