using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GCommon;

internal class AppendOnlyStrPool
{
	private class RecyclePair
	{
		public byte[] Buf;

		public int Pos;

		public int LeftSize;

		public unsafe byte* Ptr;
	}

	private const int PageSize = 4096;

	private const int BytesHeadPad = 32;

	private const int AllocSize = 4064;

	private const int RecycleSize = 100;

	public Encoding Encoding;

	private List<RecyclePair> m_RecyleList;

	private List<byte[]> m_FilledList;

	private byte[] m_CurrentBuf;

	private int m_Pos;

	private int m_LeftSize;

	private unsafe byte* p_Pos;

	private unsafe static readonly void* s_klass;

	private static readonly int s_StrSizeOffset;

	private static readonly int s_HeadSize;

	private static readonly int s_HeadTailSize;

	private static readonly int s_Align;

	private string[] m_Ptr2StrArray;

	private ArrayPtr<string> m_Ptr2Str;

	public unsafe string Alloc(char* value, int charCount)
	{
		return null;
	}

	public unsafe string Alloc(byte* utf8Bytes, int byteCount)
	{
		return null;
	}

	public string ReadChars(Stream s, int charCount)
	{
		return null;
	}

	private unsafe byte* AllocAndSetLength(int len)
	{
		return null;
	}

	private unsafe byte* AllocAndSetLength(int len, out int pos)
	{
		pos = default(int);
		return null;
	}

	private bool RecyleAndFindBuf(int allocLen)
	{
		return false;
	}

	private void SetCurrentBuf(RecyclePair pair)
	{
	}

	private void AllocAndSetCurrentBuf(int allocLen)
	{
	}
}
