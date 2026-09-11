using System.IO;

namespace GCommon;

public class UDPMsgPacket : ObjectPoolCallbackBase
{
	private static SyncedObjectPool<UDPMsgPacket> m_MsgPacketPool;

	public const uint UDPMESSAGE_HEADER_MINI_SIZE = 5u;

	public const uint UDPMESSAGE_HEADER_RELIABLE_SIZE = 10u;

	public const uint UDPMESSAGE_HEADER_NONRELIABLE_SIZE = 8u;

	public const byte UDPMESSAGE_SENDOPTION_NONE = 0;

	public const byte UDPMESSAGE_SENDOPTION_HELLO = 1;

	public const byte UDPMESSAGE_SENDOPTION_RELIABLE = 2;

	public const byte UDPMESSAGE_SENDOPTION_BYEBYE = 3;

	public const byte UDPMESSAGE_SENDOPTION_VAR = 4;

	public const byte UDPMESSAGE_SENDOPTION_VAR_RELIABLE = 5;

	public const uint UDPMESSAGE_FLAG_ENCRYPTION = 1u;

	public const uint UDPMESSAGE_FLAG_ZIP = 2u;

	public byte MsgKey;

	public byte CRC7;

	public byte SendOption;

	public ushort Cmd;

	public ushort OrderID;

	public byte Flags;

	public ushort Length;

	public ulong DestinationIP;

	public byte[] Data;

	public bool IsPendingResend;

	public bool IsAcked;

	public double NextResendTime;

	public int ResendCount;

	public double ResendTimeRatio;

	public bool IsResend;

	public static UDPMsgPacket Get()
	{
		return null;
	}

	public static void Put(UDPMsgPacket p)
	{
	}

	public static UDPMsgPacket Clone(UDPMsgPacket srcPacket)
	{
		return null;
	}

	public static void ClearCache()
	{
	}

	public override void OnAllocated()
	{
	}

	public uint Unserialize(IUDPSession session, BinaryReader reader, int availableLength)
	{
		return 0u;
	}

	public uint Serialize(IUDPSession session, BinaryWriter writer)
	{
		return 0u;
	}

	public uint ProxySerialize(IUDPSession session, BinaryWriter writer, ushort cmdToWrite)
	{
		return 0u;
	}

	public static bool NeedProxyUnSerialze(uint cmd)
	{
		return false;
	}

	public static bool IsReliable(uint cmd, byte sendOption)
	{
		return false;
	}

	public bool IsReliable()
	{
		return false;
	}

	public bool IsVarPacket()
	{
		return false;
	}
}
