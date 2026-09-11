using System.Collections.Generic;
using System.IO;
using GCommon;

namespace COW;

public class KillCamData
{
	public int Time;

	public ushort Cmd;

	public ushort Length;

	public byte SendOption;

	public byte[] Data;

	public void Deserialize(BinaryReader reader)
	{
	}

	public KillCamData Clone()
	{
		return null;
	}

	public static implicit operator UDPMsgPacket(KillCamData replay)
	{
		return null;
	}

	public void SerializeTo(List<byte> list)
	{
	}

	private static int ReadInt32(List<byte> list, int p)
	{
		return 0;
	}

	private static ushort ReadUInt16(List<byte> list, int p)
	{
		return 0;
	}

	private static int ReadLength(List<byte> list, int len, int p)
	{
		return 0;
	}

	public static int ReadDataSize(List<byte> list, int len, int p)
	{
		return 0;
	}

	public bool DeserializeTimeOnly(List<byte> list, int len, ref int p)
	{
		return false;
	}

	public bool DeserializeCmdOnly(List<byte> list, int len, ref int p)
	{
		return false;
	}

	public bool DeserializeNoBytes(List<byte> list, int len, ref int p)
	{
		return false;
	}
}
