using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using ICSharpCode.SharpZipLib.GZip;

namespace GCommon;

public class MUDPSession : NetworkSession, IUDPSession
{
	private class HelloData
	{
		public bool HasNewConnectionResponse;

		public UDPMessageIDReserved Cmd;

		public string SessionKey;

		public string Addr;
	}

	public static bool UseTCPMode;

	public static bool EnableCachedIPV6State;

	private const int RECV_BUFF_SIZE = 512000;

	private const int SEND_BUFF_SIZE = 128000;

	private SocketClient m_UDPConnetion;

	private IPEndPoint m_IPEndPoint;

	private Thread m_KeepAliveThread;

	private AutoResetEvent m_KeepAliveSignalEvent;

	private NetworkByteStream m_RecvBuffer;

	private MemoryStream m_RecvMemoryStream;

	private object m_HelloPacketLock;

	private HelloData m_HelloPacket;

	private Queue<UDPMsgPacket> m_SendPacketQueue;

	private double m_MaxDeactiveTime;

	private object m_LastAliveTimeLock;

	private double m_LastAliveTime;

	private bool m_NeedKeepAlive;

	private MemoryStream m_AckStream;

	private BinaryWriter m_AckWriter;

	private object m_SocketExceptionLock;

	private bool m_IsSocketRaiseException;

	private bool m_NeedReconnectFlag;

	private double m_ReconnectEndTime;

	private string m_SessionKey;

	private string m_Addr;

	private bool m_HasConnected;

	public static bool DebugDropAll;

	private ENetworkType _003CNetworkType_003Ek__BackingField;

	private EClientState _003CClientState_003Ek__BackingField;

	public bool NetworkAvailableFromMonitor;

	private bool _003CIsInitialized_003Ek__BackingField;

	private byte[] m_DecTempBuffer;

	private TeaDecTempBuffer m_DecBuffer;

	private byte[] m_EncTempBuffer;

	private TeaEncTempBuffer m_EncBuffer;

	private byte[] m_ZipWorkingBuffer;

	private byte[] m_ZipOutputBuffer;

	private GZipInputStream m_GZipInputStream;

	private MultiNetworkSession _003CParentMultiNetworkSession_003Ek__BackingField;

	private string m_DeviceID;

	private List<UDPMsgPacket> m_PacketToResend;

	private MUDPConnectionTracking m_ConnectionTracking;

	private bool? m_IPV6Only;

	private byte[] m_Nat64Prefix;

	private byte[] m_TargetSecretKey;

	private int[] m_TargetHeadSecretKey;

	private bool m_ForceUseDefaultUDP;

	private MemoryStream m_sendSplitStream;

	private FastBinaryWriter m_sendSplitWriter;

	private S2C_C2S_RUDP_SPLITTED_DATAGRAM m_splittedDatagram;

	private List<byte> m_splittedDatagramBuf;

	private uint m_datagramID;

	private Random m_Random;

	public ENetworkType NetworkType
	{
		get
		{
			return _003CNetworkType_003Ek__BackingField;
		}
		private set
		{
			_003CNetworkType_003Ek__BackingField = value;
		}
	}

	public EClientState ClientState
	{
		get
		{
			return _003CClientState_003Ek__BackingField;
		}
		private set
		{
			_003CClientState_003Ek__BackingField = value;
		}
	}

	public bool IsInitialized
	{
		get
		{
			return _003CIsInitialized_003Ek__BackingField;
		}
		private set
		{
			_003CIsInitialized_003Ek__BackingField = value;
		}
	}

	public byte[] DecTempBuffer => null;

	public TeaDecTempBuffer DecBuffer => null;

	public byte[] EncTempBuffer => null;

	public TeaEncTempBuffer EncBuffer => null;

	public byte[] ZipWorkingBuffer => null;

	public byte[] ZipOutputBuffer => null;

	public GZipInputStream GZipInputStream => null;

	public MultiNetworkSession ParentMultiNetworkSession
	{
		get
		{
			return _003CParentMultiNetworkSession_003Ek__BackingField;
		}
		set
		{
			_003CParentMultiNetworkSession_003Ek__BackingField = value;
		}
	}

	public MUDPSession(MultiNetworkSession session, string deviceId, ENetworkType type, bool need_keep_alive = true)
	{
	}

	public override bool IsConnected()
	{
		return false;
	}

	private bool CreateAndConnectSocket(IPEndPoint endPoint, bool isReconnect = false)
	{
		return false;
	}

	public void ForceToUseDefaultUDP()
	{
	}

	public void ForceToRecconnect()
	{
	}

	private bool CheckReconnect()
	{
		return false;
	}

	private void InvokeConnectionResult()
	{
	}

	private void UpdateSessionKey(string key, string addr)
	{
	}

	protected override bool OnConnect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	public bool MConnect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	public void SetSecretKey(byte[] key)
	{
	}

	public byte[] GetSecretKey()
	{
		return null;
	}

	public void SetHeadSecretKey(int[] key)
	{
	}

	public int[] GetHeadSecretKey()
	{
		return null;
	}

	public void ClearCachedIPV6State()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void OnReconnectSuccess()
	{
	}

	protected override void OnClose()
	{
	}

	private void SendHello()
	{
	}

	public void SendReconnect(string sessionKey, string addr)
	{
	}

	private void UpdateResendConnectionPacket()
	{
	}

	public override void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
	{
	}

	public void Send(UDPMsgPacket packet)
	{
	}

	public void Resend(List<UDPMsgPacket> packets)
	{
	}

	private void CreateKeepAliveThread()
	{
	}

	private void OnRecvDataThreadNoSleep()
	{
	}

	private void OnRecvDataThread()
	{
	}

	private void HandleRecv(BinaryReader binaryReader)
	{
	}

	private void OnSendDataThread()
	{
	}

	private void RealSendDataThread()
	{
	}

	private void OnKeepAliveThread()
	{
	}

	public bool IsClosed()
	{
		return false;
	}

	public void OnDisconnected()
	{
	}
}
