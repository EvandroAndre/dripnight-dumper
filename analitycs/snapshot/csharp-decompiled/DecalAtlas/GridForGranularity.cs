using System;
using System.Collections.Generic;

namespace DecalAtlas;

[Serializable]
public class GridForGranularity
{
	public int Granularity;

	public int NumberOfCells;

	private GridCell[] _PersistCells;

	[NonSerialized]
	public GridCell[] RuntimeCells;

	[NonSerialized]
	public Dictionary<int, int> IndexMap;

	public void Load()
	{
	}
}
