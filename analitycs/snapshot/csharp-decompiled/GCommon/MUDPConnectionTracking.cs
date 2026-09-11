using System.Collections.Generic;

namespace GCommon;

public class MUDPConnectionTracking
{
	private object m_Locker;

	private LinkedList<UDPMsgPacket> m_PendingAckPacket;

	private ENetworkType m_NetworkType;

	private bool m_FlushForLongDeactiveTime;

	private double m_LastFlushTime;

	public bool NeedFlushForLongDeactiveTime => false;

	public MUDPConnectionTracking(ENetworkType networkType = ENetworkType.Wifi)
	{
	}

	public void UpdateActiveTime(double last, double current)
	{
	}

	public void ApplyConnectionTrackingInfo(UDPMsgPacket packet)
	{
	}

	public void HandleConnectionAck(ushort ack)
	{
	}

	public bool Update(ref List<UDPMsgPacket> packetToResend)
	{
		return false;
	}
}
