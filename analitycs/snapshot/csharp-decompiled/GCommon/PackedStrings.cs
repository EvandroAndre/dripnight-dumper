using System.Collections.Generic;
using System.Text;

namespace GCommon;

public class PackedStrings
{
	public PackedStringsSettings Settings;

	public string[] PrefixStrs;

	public uint[] Indexes;

	public int SuffixStrsCnt;

	public int SuffixBytesLen;

	public List<string> Overwrites;

	private StringBuilder m_Sb;

	public byte[] SuffixBytes;

	public int Count => 0;

	public string Get(int t)
	{
		return null;
	}

	public void Overwrite(uint t, string s)
	{
	}

	public void PrintSize(string label = "")
	{
	}

	public static PackedStrings Deserialize(byte[] bs, ref int p)
	{
		return null;
	}

	public static void Align(ref int p, int align)
	{
	}
}
