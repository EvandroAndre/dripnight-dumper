using System.Collections.Generic;
using GCommon;

namespace UMA.Simple;

public class SlotOverlayUrlSplitResultPacked
{
	public const char Sp = '_';

	public int RecordCount;

	public int LoadedRecords;

	internal bool m_UsePrefixStr;

	internal bool m_OffsetTimes4;

	internal int m_MinUrlLength;

	internal int m_MaxUrlLength;

	public List<string> PrefixStrs;

	public List<string> CenterStrs;

	public List<string> SuffixStrs;

	internal bool m_UsingShortOffset;

	internal ushort[] m_OffsetShort;

	internal int[] m_OffsetLong;

	private MutableString m_Sb;

	private MutableString[] m_Sbs;

	public int DataLength;

	internal byte[] m_Data;

	public void OnTransfered()
	{
	}

	public string GetUrl(int idx)
	{
		return null;
	}

	public bool GetUrl(int idx, MutableString sb)
	{
		return false;
	}

	public string GetUrlWithSharedString(int idx)
	{
		return null;
	}

	public void FreeData()
	{
	}

	private MutableString GetSbWithLength(int strLen)
	{
		return null;
	}

	private static void ReadIndexStrAndAppendTo(MutableString sb, List<string> strs, byte[] data, ref int p, int offset)
	{
	}

	private static void ReadIndexStrLen(byte[] data, ref int p, List<string> strs, out string str, ref int sbLen, int offset)
	{
		str = null;
	}

	private static void ReadStrAndAppendTo(MutableString sb, byte[] data, ref int p)
	{
	}

	private static void ReadStrLen(byte[] data, ref int p, out int strLen, out int strOffset, ref int sbLen)
	{
		strLen = default(int);
		strOffset = default(int);
	}

	private static void AppendTo(MutableString sb, byte[] data, int start, int cnt)
	{
	}
}
