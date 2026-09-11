namespace GCommon;

public class FakeFastBinaryReader : FastBinaryReader
{
	public FakeFastBinaryReader()
		: base(null)
	{
	}

	public override uint ReadUInt32()
	{
		return 0u;
	}

	public override int ReadInt32()
	{
		return 0;
	}

	public override ulong ReadUInt64()
	{
		return 0uL;
	}

	public override long ReadInt64()
	{
		return 0L;
	}

	public override short ReadInt16()
	{
		return 0;
	}

	public override ushort ReadUInt16()
	{
		return 0;
	}

	public override float ReadSingle()
	{
		return 0f;
	}

	public override void ReadBytes(ref byte[] outputBytes, int count)
	{
	}

	public override bool ReadBoolean()
	{
		return false;
	}

	public override string ReadString()
	{
		return null;
	}

	public override byte ReadByte()
	{
		return 0;
	}

	public override sbyte ReadSByte()
	{
		return 0;
	}

	public override uint ReadFixUInt32()
	{
		return 0u;
	}

	public override int ReadFixInt32()
	{
		return 0;
	}

	public override ulong ReadFixUInt64()
	{
		return 0uL;
	}

	public override long ReadFixInt64()
	{
		return 0L;
	}

	public override bool ReadFixBoolean()
	{
		return false;
	}

	public override float ReadFixSingle()
	{
		return 0f;
	}

	public override short ReadFixInt16()
	{
		return 0;
	}

	public override ushort ReadFixUInt16()
	{
		return 0;
	}

	public override byte ReadFixByte()
	{
		return 0;
	}

	public override sbyte ReadFixSByte()
	{
		return 0;
	}
}
