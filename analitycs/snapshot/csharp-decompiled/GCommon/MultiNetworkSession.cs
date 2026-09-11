using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace GCommon;

public class MultiNetworkSession : ISessionHanlder, INetworkSession, PlatformUtility.INetworkCallback
{
	private enum EReconnectState
	{
		NetworkFailure,
		NetworkRecoverCheckCellular,
		NetworkRequest,
		NetworkAvailable
	}

	private Dictionary<int, MUDPSession> m_Sessions;

	private UDPReliableTracking m_ReliableTracking;

	private int m_PacketId;

	private Queue<UDPMsgPacket> m_SendPacketQueue;

	private List<UDPMsgPacket> m_PacketToResend;

	private Queue<UDPMsgPacket> m_RecvPacketQueue;

	private LinkedList<UDPMsgPacket> m_PendingReliableRecvPacket;

	private bool m_UseMUDP;

	private ENetworkType m_ExceptionNetworkType;

	private bool m_CellularDisconnectedHalfway;

	private bool m_ForceCheckCellularNoNetworkValid;

	private bool m_TryToUseDefaultUDP;

	private ISessionHanlder m_SessionHandler;

	private object m_Locker;

	private object m_exceptionLocker;

	private string m_DeviceID;

	private const uint m_TickInterval = 10u;

	private string m_EndPointIp;

	private int m_EndPointPort;

	private string m_ProxyIp;

	private int m_ProxyPort;

	private int m_Tickout;

	private int m_TimeOutTickCount;

	private int m_LastPingSentTickcount;

	private StringBuilder m_SendLog;

	private StringBuilder m_RecvLog;

	private bool m_Init;

	private AutoResetEvent m_UnSerializeMsgSignalEvent;

	private int m_LastPing;

	private int m_A500;

	protected bool m_ConnectProxy;

	private bool m_NeedKeepAlive;

	private double m_KeepAliveInterval;

	private double m_LastKeepAliveTime;

	private MemoryStream m_PingStream;

	private FastBinaryWriter m_PingBinaryWriter;

	private C2S_UDP_Ping_Req m_PingKeepAliveMsg;

	private EReconnectState m_Reconnection;

	public UDPReliableTracking SharedReliableTracking
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public MultiNetworkSession(bool need_keep_alive = true, ISessionHanlder cb = null)
	{
	}

	public void InitSession(MUDPSession sess)
	{
	}

	public void SetKeepAliveInterval(double interval)
	{
	}

	public int GetLastPing()
	{
		return 0;
	}

	public void SaveLastPing()
	{
	}

	public virtual void Update()
	{
	}

	public bool IsConnected()
	{
		return false;
	}

	public bool Connect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	public void Close(bool isSendNotification = true)
	{
	}

	public void ForceToRecconnect()
	{
	}

	public AutoResetEvent ReceiveNewMsgSignal()
	{
		return null;
	}

	public void CloseReceiveNewMsgSignal()
	{
	}

	public void GetUDPPackets(List<UDPMsgPacket> outPackets)
	{
	}

	public void OnApplicationPause(bool paused)
	{
	}

	public void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
	{
	}

	private void UpdateKeepAlive()
	{
	}

	private void UpdateResend()
	{
	}

	public void ResetIsPendingResend()
	{
	}

	public void OnConnected(bool result)
	{
	}

	public void OnDisconnected(DisconnectedReason reason)
	{
	}

	public void OnSocketException(DisconnectedReason reason = DisconnectedReason.Unknown, ENetworkType networkType = ENetworkType.Wifi)
	{
	}

	private void CheckException()
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

	public void GenerateAckBits(UDPMsgPacket newMsgPacket, ref ushort firstBitOrderID, ref byte[] ackOrderBits)
	{
	}

	public void OnMUDPPacketRecv(UDPMsgPacket newMsgPacket, ENetworkType networkType)
	{
	}

	public void OnNetworkCallback(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}

	private void CheckAndBindSession(ENetworkType networkType)
	{
	}

	public void OnNetworkChanged(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}
}
