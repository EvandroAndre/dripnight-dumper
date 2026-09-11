using System.IO;

namespace GCommon;

public class RegionMaskData
{
	private RegionMaskHeader m_header;

	private RegionColorEntry[] m_colorTable;

	private byte[] m_typemask;

	private uint[] m_internalChildStart;

	private uint[] m_leafChildStart;

	private byte[] m_leafRegionID;

	private bool m_rootIsLeaf;

	private RegionQuadNode[] m_nodes;

	private static readonly int[] s_popCount4Tbl;

	public RegionMaskHeader Header => default(RegionMaskHeader);

	public RegionColorEntry[] ColorTable => null;

	public byte[] Typemask => null;

	public uint[] InternalChildStart => null;

	public uint[] LeafChildStart => null;

	public byte[] LeafRegionID => null;

	public bool RootIsLeaf => false;

	public RegionQuadNode[] Nodes => null;

	public RegionMaskData()
	{
	}

	public RegionMaskData(RegionMaskHeader header, RegionQuadNode[] nodes, RegionColorEntry[] colorTable)
	{
	}

	public bool BuildSplitArrays(bool releaseFlatNodes)
	{
		return false;
	}

	public bool LoadFromStream(BinaryReader reader)
	{
		return false;
	}

	private bool LoadV3Payload(BinaryReader reader)
	{
		return false;
	}

	private static int PopCount4(byte nibble)
	{
		return 0;
	}

	public void SaveToStream(BinaryWriter writer)
	{
	}

	public bool LoadFromBytes(byte[] bytes)
	{
		return false;
	}

	public byte[] ToBytes()
	{
		return null;
	}

	public int GetMemorySize()
	{
		return 0;
	}

	public int GetFileSize()
	{
		return 0;
	}
}
