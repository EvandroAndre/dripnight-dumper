using System.IO;
using Unity.Collections;

namespace GCommon;

public class MutableStringReader : TextReaderExt
{
	private MutableString m_Str;

	private string m_Src;

	private byte[] m_SrcBytes;

	private unsafe byte* p_begin;

	private unsafe byte* p_end;

	private unsafe byte* p_next;

	private int p_step;

	public long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public MutableStringReader(string text)
	{
	}

	public MutableStringReader(byte[] asciiBytes)
	{
	}

	public MutableStringReader(MemoryStream ansiStream)
	{
	}

	public MutableStringReader(NativeArray<byte> nativeArray)
	{
	}

	public MutableStringReader(NativeReadStream nativeStream)
	{
	}

	internal int NextLineLength()
	{
		return 0;
	}

	public override string ReadLine(bool aquire)
	{
		return null;
	}

	public override string ReadLine()
	{
		return null;
	}

	public override void SkipLine()
	{
	}

	public override void ReadLine(MutableString mutableStr)
	{
	}
}
