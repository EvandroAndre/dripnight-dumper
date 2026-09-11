using System.Collections.Generic;
using System.IO;

namespace GCommon;

public class NetworkDetectionClient : NetworkClient, ISessionHanlder
{
	protected UDPSession m_UDPSession;

	protected MemoryStream m_SendMemoryStream;

	protected MemoryStream m_RecvMemoryStream;

	protected FastBinaryReader m_BinaryReader;

	protected FastBinaryWriter m_BinaryWriter;

	protected List<UDPMsgPacket> m_RecvUDPMsgList;

	protected float m_LastRecvPingPacketTime;

	protected bool m_HavePingSent;

	private int m_LastSendTime;

	private Queue<int> m_PingQueue;

	private int m_TotalPingValue;

	private int m_CurPingValue;

	private int m_TimeOutCount;

	private const int PING_COUNT = 5;

	private float m_PingTimeout;

	private int PING_MAXVALUE => 0;

	public NetworkDetectionClient(float ping_timeout)
	{
	}

	public int CurrentPingValue()
	{
		return 0;
	}

	public float PingLossRate()
	{
		return 0f;
	}

	public bool IsReadyForReadPing()
	{
		return false;
	}

	private void Clear()
	{
	}

	private bool IsTimeOut()
	{
		return false;
	}

	private void RequestPing()
	{
	}

	private void OnMsgPingRes(S2C_UDP_Ping_Res msg)
	{
	}

	private void PushPingPack(int sendCount)
	{
	}

	private void PushPingValue(int value)
	{
	}

	public void Update()
	{
	}

	public bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return false;
	}

	public void OnConnected(bool result)
	{
	}

	public void OnDisconnected(DisconnectedReason reason = DisconnectedReason.Unknown)
	{
	}

	public void OnPingSent(int lastSentTime)
	{
	}

	public void OnPingReceiveTimeout()
	{
	}

	public void OnReconnect()
	{
	}

	protected virtual void HandleRecvPacket()
	{
	}
}
