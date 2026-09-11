using UnityEngine;

namespace GCommon;

public class RegionMaskQuery
{
	private RegionMaskData m_data;

	private bool m_isLoaded;

	private float m_mapStartX;

	private float m_mapStartZ;

	private float m_mapWidth;

	private float m_mapHeight;

	private int m_resolution;

	private float m_invMapWidth;

	private float m_invMapHeight;

	private byte[] m_typemask;

	private uint[] m_internalChildStart;

	private uint[] m_leafChildStart;

	private byte[] m_leafRegionID;

	private bool m_rootIsLeaf;

	private static readonly int[] s_popCount4;

	public bool IsLoaded => false;

	public RegionMaskData Data => null;

	public bool Initialize(RegionMaskData data)
	{
		return false;
	}

	public bool LoadFromBytes(byte[] bytes)
	{
		return false;
	}

	public bool LoadFromFile(string filePath)
	{
		return false;
	}

	public bool LoadFromTextAsset(TextAsset textAsset)
	{
		return false;
	}

	public byte GetRegionID(float worldX, float worldZ)
	{
		return 0;
	}

	public byte GetRegionID(Vector3 worldPos)
	{
		return 0;
	}

	public bool IsInRegion(float worldX, float worldZ, byte regionID)
	{
		return false;
	}

	public bool IsInRegions(float worldX, float worldZ, byte[] regionIDs)
	{
		return false;
	}

	private byte TraverseQuadTree(int x, int z)
	{
		return 0;
	}

	private static int PopCount4(byte nibble)
	{
		return 0;
	}

	public Color32 GetRegionColor(byte regionID)
	{
		return default(Color32);
	}

	public void Clear()
	{
	}

	public string GetMemoryStats()
	{
		return null;
	}
}
