using System;

namespace DecalAtlas;

[Serializable]
public class GridCell
{
	public int Index;

	public int[] PersistDecals;

	[NonSerialized]
	public bool[,] RuntimeDecalVisibilities;

	public void Load()
	{
	}
}
