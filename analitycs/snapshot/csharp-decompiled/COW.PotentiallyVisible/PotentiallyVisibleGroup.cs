using System.Collections.Generic;
using UnityEngine;

namespace COW.PotentiallyVisible;

public class PotentiallyVisibleGroup : ScriptableObject
{
	public int StartX;

	public int StartZ;

	public int EndX;

	public int EndZ;

	public int TileSize;

	public int PortalSize;

	public List<TileData> tileList;
}
