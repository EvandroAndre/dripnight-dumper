using System;

namespace GCommon;

[Serializable]
public struct RegionMaskHeader
{
	public const int MAGIC = 1380798788;

	public const int VERSION = 3;

	public int magic;

	public int version;

	public float mapStartX;

	public float mapStartZ;

	public float mapWidth;

	public float mapHeight;

	public int resolution;

	public int nodeCount;

	public int colorCount;

	public int leafCount;

	public int internalCount;

	public static RegionMaskHeader Create(float startX, float startZ, float width, float height, int resolution)
	{
		return default(RegionMaskHeader);
	}
}
