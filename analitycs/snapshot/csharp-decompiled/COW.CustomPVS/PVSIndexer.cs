using System.Collections.Generic;
using UnityEngine;

namespace COW.CustomPVS;

public class PVSIndexer
{
	private Bounds m_MapBounds;

	private Vector3Int m_TileCount;

	private Vector3Int m_PortalCount;

	private Vector3 m_TileSize;

	private Vector3 m_PortalSize;

	private Vector3 m_InverseTileSize;

	private Vector3 m_InversePortalSize;

	private int m_TotalTileCount;

	private int m_TotalPortalCount;

	private int m_PortalHeightY;

	private List<short> m_PortalGroundHeights;

	private Dictionary<int, Bounds> m_CustomTileBounds;

	private List<KeyValuePair<Bounds, List<int>>> m_CustomTileGroups;

	private bool m_UseCustomTile;

	public void Clear()
	{
	}

	public void InitMap(Bounds mapBounds, Vector3Int tileCount)
	{
	}

	public void InitTile(int tileIndex, Vector3Int portalCount, int portalHeightY, List<short> portalGroundHeights)
	{
	}

	public void InitCustomTileConfig(List<KeyValuePair<Bounds, List<int>>> tileGroups, Dictionary<int, Bounds> tileBounds)
	{
	}

	private int InternalIndex1D(Vector3Int count, Vector3Int index3D)
	{
		return 0;
	}

	private Vector3Int InternalIndex3D(Vector3 position, Vector3 min, Vector3 inverseSize)
	{
		return default(Vector3Int);
	}

	public bool IsInMap(Vector3 position)
	{
		return false;
	}

	public bool GetTileIndex(Vector3 position, out int tileIndex)
	{
		tileIndex = default(int);
		return false;
	}

	public bool GetPortalAndOffsetIndex(Vector3 position, int tileIndex, out int portalIndex)
	{
		portalIndex = default(int);
		return false;
	}
}
