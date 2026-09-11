using System.IO;
using System.Runtime.InteropServices;

namespace GCommon;

public class FastBinaryReader
{
	[StructLayout(LayoutKind.Explicit)]
	private struct FloatToUint
	{
		[FieldOffset(0)]
		public float fVal;

		[FieldOffset(0)]
		public uint uVal;
	}

	private Stream _stream;

	private byte[] _ioBuffer;

	private int _ioIndex;

	private int _available;

	private byte[] _strBytes;

	public static bool OptReadFloat;

	private FloatToUint m_FloatToUint;

	private const long Int64Msb = long.MinValue;

	public long Position => 0L;

	public long Length => 0L;

	public FastBinaryReader(Stream s)
	{
	}

	public void Reset()
	{
	}

	public virtual uint ReadUInt32()
	{
		return 0u;
	}

	public virtual int ReadInt32()
	{
		return 0;
	}

	public virtual ulong ReadUInt64()
	{
		return 0uL;
	}

	public virtual long ReadInt64()
	{
		return 0L;
	}

	public virtual short ReadInt16()
	{
		return 0;
	}

	public virtual ushort ReadUInt16()
	{
		return 0;
	}

	public virtual float ReadSingle()
	{
		return 0f;
	}

	public virtual void ReadBytes(ref byte[] outputBytes, int count)
	{
	}

	private byte[] ReadBytes(int count)
	{
		return null;
	}

	private void ReadBytes_Optimized(ref byte[] outputBytes, int count)
	{
	}

	public virtual string ReadString()
	{
		return null;
	}

	public virtual bool ReadBoolean()
	{
		return false;
	}

	public virtual byte ReadByte()
	{
		return 0;
	}

	public virtual sbyte ReadSByte()
	{
		return 0;
	}

	public void Seek(int count)
	{
	}

	private long Zag(ulong ziggedValue)
	{
		return 0L;
	}

	public ulong ReadVariant()
	{
		return 0uL;
	}

	internal void Ensure(int count)
	{
	}

	private int TryReadUInt64VariantWithoutMoving(out ulong value)
	{
		value = default(ulong);
		return 0;
	}

	public virtual uint ReadFixUInt32()
	{
		return 0u;
	}

	public virtual int ReadFixInt32()
	{
		return 0;
	}

	public virtual ulong ReadFixUInt64()
	{
		return 0uL;
	}

	public virtual long ReadFixInt64()
	{
		return 0L;
	}

	public virtual bool ReadFixBoolean()
	{
		return false;
	}

	public virtual float ReadFixSingle()
	{
		return 0f;
	}

	public virtual short ReadFixInt16()
	{
		return 0;
	}

	public virtual ushort ReadFixUInt16()
	{
		return 0;
	}

	public virtual byte ReadFixByte()
	{
		return 0;
	}

	public virtual sbyte ReadFixSByte()
	{
		return 0;
	}

	private ulong TryReadFixU64()
	{
		return 0uL;
	}

	private uint TryReadFixU32()
	{
		return 0u;
	}

	private ushort TryReadFixU16()
	{
		return 0;
	}

	private byte TryReadFixU8()
	{
		return 0;
	}
}
