using System.IO;

namespace GCommon;

public class TCPMsgPacket
{
	public const uint TCPMESSAGE_CMD_HEADER_SIZE = 1u;

	public const uint TCPMESSAGE_LENGTH_HEADER_SIZE = 4u;

	public const uint TCPMESSAGE_HEADER_SIZE = 5u;

	public byte Cmd;

	public byte Region;

	public int Length;

	public byte[] Data;

	public object UnSerializedDataObject;

	public AccessValidInfo accessValidInfo;

	public uint Unserialize(BinaryReader reader)
	{
		return 0u;
	}

	public void Serialize(BinaryWriter writer)
	{
	}

	public static bool IsHeartbeatPackage(int cmd)
	{
		return false;
	}

	public static bool IsInitPackage(int cmd)
	{
		return false;
	}

	public static byte GetInitPackageCmd()
	{
		return 0;
	}
}
