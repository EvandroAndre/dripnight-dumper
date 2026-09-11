using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using ICSharpCode.SharpZipLib.GZip;

namespace GCommon;

public class UDPSession : NetworkSession, IUDPSession, INetworkSession
{
	private class HelloData
	{
		public bool HasNewConnectionResponse;

		public UDPMessageIDReserved Cmd;

		public string SessionKey;
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

	private Queue<UDPMsgPacket> m_RecvPacketQueue;

	private LinkedList<UDPMsgPacket> m_PendingReliableRecvPacket;

	private object m_HelloPacketLock;

	private HelloData m_HelloPacket;

	private Queue<UDPMsgPacket> m_SendPacketQueue;

	private double m_KeepAliveInterval;

	private double m_LastKeepAliveTime;

	private MemoryStream m_PingStream;

	private FastBinaryWriter m_PingBinaryWriter;

	private C2S_UDP_Ping_Req m_PingKeepAliveMsg;

	private int m_LastPingSentTickcount;

	private double m_MaxDeactiveTime;

	private object m_LastAliveTimeLock;

	private double m_LastAliveTime;

	private bool m_NeedKeepAlive;

	private AutoResetEvent m_UnSerializeMsgSignalEvent;

	private UDPReliableTracking m_ReliableTracking;

	private List<UDPMsgPacket> m_PacketToResend;

	private MemoryStream m_AckStream;

	private BinaryWriter m_AckWriter;

	private object m_SocketExceptionLock;

	private bool m_IsSocketRaiseException;

	private bool m_NeedReconnectFlag;

	private double m_ReconnectEndTime;

	private string m_SessionKey;

	private bool m_HasConnected;

	public static bool DebugDropAll;

	private StringBuilder m_SendLog;

	private StringBuilder m_RecvLog;

	private StringBuilder m_RUDPSendLog;

	private StringBuilder m_RUDPRecvLog;

	private byte[] m_TargetSecretKey;

	private int[] m_TargetHeadSecretKey;

	private bool? m_IPV6Only;

	private byte[] m_Nat64Prefix;

	private byte[] m_DecTempBuffer;

	private TeaDecTempBuffer m_DecBuffer;

	private byte[] m_EncTempBuffer;

	private TeaEncTempBuffer m_EncBuffer;

	private byte[] m_ZipWorkingBuffer;

	private byte[] m_ZipOutputBuffer;

	private GZipInputStream m_GZipInputStream;

	private string m_DeviceID;

	private MemoryStream m_sendSplitStream;

	private FastBinaryWriter m_sendSplitWriter;

	private S2C_C2S_RUDP_SPLITTED_DATAGRAM m_splittedDatagram;

	private List<byte> m_splittedDatagramBuf;

	private uint m_datagramID;

	private int m_LastPing;

	private int m_A500;

	private Random m_Random;

	public byte[] DecTempBuffer => null;

	public TeaDecTempBuffer DecBuffer => null;

	public byte[] EncTempBuffer => null;

	public TeaEncTempBuffer EncBuffer => null;

	public byte[] ZipWorkingBuffer => null;

	public byte[] ZipOutputBuffer => null;

	public GZipInputStream GZipInputStream => null;

	public UDPSession(ISessionHanlder cb = null, bool need_keep_alive = true)
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

	public AutoResetEvent ReceiveNewMsgSignal()
	{
		return null;
	}

	public void CloseReceiveNewMsgSignal()
	{
	}

	private void UpdateSessionKey(string key)
	{
	}

	protected override bool OnConnect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	private void UpdateKeepAlive()
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

	public override void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
	{
	}

	public void Resend(List<UDPMsgPacket> packets)
	{
	}

	public void GetUDPPackets(List<UDPMsgPacket> outPackets)
	{
	}

	public new void SetKeepAliveInterval(double interval)
	{
	}

	public int GetLastPing()
	{
		return 0;
	}

	public void SaveLastPing()
	{
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

	public void ResetIsPendingResend()
	{
	}

	private void OnKeepAliveThread()
	{
	}

	public void OnNetworkChanged(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}

	public void ClearCachedIPV6State()
	{
	}
}
