using System.Collections.Generic;

namespace GCommon;

public class PackedResconfUrls
{
	public const uint Magic = 2905927510u;

	public const uint Version = 1u;

	public PackedStrings m_PackedStrs;

	public int CompactOffset;

	public int PackedCount;

	public int CompactEnd;

	public int NonCompactEnd;

	public int OverwriteCount;

	public List<string> AdditionalUrls;

	public List<string> AdditionalCompactUrls;

	public void PrintSize(string label)
	{
	}

	private void UpdateCnt()
	{
	}

	public void AddUrl(bool compact, string url)
	{
	}

	public void OverwriteUrl(int index, bool compact, string url)
	{
	}

	public string GetUrl(int index, bool compact)
	{
		return null;
	}

	public static PackedResconfUrls Deserialize(byte[] bs, ref int p)
	{
		return null;
	}
}
