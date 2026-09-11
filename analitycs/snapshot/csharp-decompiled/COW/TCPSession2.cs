using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Threading;
using GCommon;

namespace COW;

public class TCPSession2
{
	public enum CloseState
	{
		None,
		CloseRequested,
		Closed
	}

	public delegate void UnSerializeHandler(TCPMsgPacket packet);

	private class RecvBlockingState
	{
		public bool IsBlocking;
	}

	public const int CONNECT_NONE = 1;

	public const int CONNECT_PENDING = 2;

	public const int CONNECT_OK = 3;

	public const int CONNECT_FAILED = 4;

	private int m_ConnectState;

	private CloseState m_CloseState;

	private object m_HasExceptionLock;

	private bool m_HasExcepetion;

	public Action<bool> OnSocketConnected;

	public Action OnException;

	private TcpClient m_TCPClient;

	private NetworkByteStream m_RecvBuffer;

	private MemoryStream m_RecvRemainingBuffer;

	private double m_KeepAliveInterval;

	private double m_MaxDeactiveTime;

	private object m_LastAliveTimeLock;

	private double m_LastAliveTime;

	private Thread m_KeepAliveThread;

	private Thread m_RecvThread;

	private Thread m_SendThread;

	private AutoResetEvent m_NotifySendEvent;

	private int m_ReceiveBufferSize;

	private int m_SendBufferSize;

	private bool m_UTCTime;

	private string m_Token;

	private Queue<TCPMsgPacket> m_SendPacketQueue;

	private Queue<TCPMsgPacket> m_RecvPacketQueue;

	private AesManaged m_Aes;

	private string m_LogTag;

	private bool m_ApplicationPaused;

	private double m_ApplicationPausedStartTime;

	private string m_LastExceptionMessage;

	public UnSerializeHandler TCPUnSerializeHandler;

	private AccessValidInfo m_AccessValidInfo;

	private RecvBlockingState m_RecvBlockingState;

	public TCPSession2(string token, string tag, AccessValidInfo accessValidInfo)
	{
	}

	public void OpenUTCTime(bool state)
	{
	}

	private AesManaged CreateAes(byte[] key, byte[] iv)
	{
		return null;
	}

	public string ConsumeLastExceptionMessage()
	{
		return null;
	}

	private void RecordLastException(string message)
	{
	}

	public bool Connect(string serverAddr, int port)
	{
		return false;
	}

	private void OnConnected(IAsyncResult ar)
	{
	}

	public bool Connected()
	{
		return false;
	}

	public bool Closed()
	{
		return false;
	}

	public CloseState GetCloseState()
	{
		return CloseState.None;
	}

	public void Send(uint cmd, byte[] data, int byteCount, byte region)
	{
	}

	public void GetTCPPackets(Queue<TCPMsgPacket> outPackets)
	{
	}

	public void Close()
	{
	}

	private void OnSendDataThread()
	{
	}

	private void OnRecvDataThread()
	{
	}

	private void OnKeepAliveThread()
	{
	}

	public byte[] Encrypt(AesManaged aes, byte[] data)
	{
		return null;
	}

	private void LogFormat(string format, object[] args)
	{
	}

	public void OnApplicationPause(bool paused)
	{
	}

	private double GetNowTimeS()
	{
		return 0.0;
	}
}
