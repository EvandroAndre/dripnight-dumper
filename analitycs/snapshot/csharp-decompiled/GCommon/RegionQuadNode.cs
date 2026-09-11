using System;
using System.Runtime.InteropServices;

namespace GCommon;

[Serializable]
[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 5)]
public struct RegionQuadNode
{
	public byte packedMeta;

	public uint childStart;

	private const byte LEAF_BIT = 128;

	private const byte REGION_MASK = 15;

	public bool IsLeaf => false;

	public byte regionID => 0;

	public byte flags => 0;

	public static RegionQuadNode CreateLeaf(byte regionID)
	{
		return default(RegionQuadNode);
	}

	public static RegionQuadNode CreateInternal(uint childStart)
	{
		return default(RegionQuadNode);
	}
}
