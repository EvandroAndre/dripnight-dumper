using System.IO;
using System.Runtime.InteropServices;

namespace GCommon;

public sealed class FastBinaryWriter
{
	[StructLayout(LayoutKind.Explicit)]
	private struct FloatToUint
	{
		[FieldOffset(0)]
		public float fVal;

		[FieldOffset(0)]
		public uint uVal;
	}

	private static ulong Normal_Byte_Count;

	private static ulong Fast_Byte_Count;

	private Stream _stream;

	private byte[] _ioBuffer;

	private int _ioIndex;

	public static bool OptWriteFloat;

	private FloatToUint m_FloatToUint;

	public static void LogProtoWriteByteCount()
	{
	}

	public FastBinaryWriter(Stream s)
	{
	}

	private void DemandSpace(int required)
	{
	}

	public void Flush()
	{
	}

	internal ulong Zig(long value)
	{
		return 0uL;
	}

	public void Write(int value)
	{
	}

	public void Write(uint value)
	{
	}

	public void Write(long value)
	{
	}

	public void Write(ulong value)
	{
	}

	public void Write(byte[] data)
	{
	}

	public void Write(float value)
	{
	}

	public void Write(short value)
	{
	}

	public void Write(ushort value)
	{
	}

	public void Write(bool value)
	{
	}

	public void Write(byte value)
	{
	}

	public void Write(sbyte value)
	{
	}

	private void AppendVarint(ulong v)
	{
	}

	public void WriteFix(int value)
	{
	}

	public void WriteFix(uint value)
	{
	}

	public void WriteFix(long value)
	{
	}

	public void WriteFix(ulong value)
	{
	}

	public void WriteFix(bool value)
	{
	}

	public void WriteFix(byte[] data)
	{
	}

	public void WriteFix(float value)
	{
	}

	public void WriteFix(short value)
	{
	}

	public void WriteFix(ushort value)
	{
	}

	public void WriteFix(byte value)
	{
	}

	public void WriteFix(sbyte value)
	{
	}

	private void WriteFixU64(ulong value)
	{
	}

	private void WriteFixU32(uint value)
	{
	}

	private void WriteFixU16(ushort value)
	{
	}

	private void WriteFixU8(byte value)
	{
	}
}
