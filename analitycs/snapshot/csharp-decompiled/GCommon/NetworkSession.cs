using System.Threading;

namespace GCommon;

public class NetworkSession
{
	protected const int CONNECT_NONE = 1;

	protected const int CONNECT_PENDING = 2;

	protected const int CONNECT_OK = 3;

	protected int m_ConnectState;

	protected bool m_Closed;

	protected int m_JoinTimeout;

	protected ISessionHanlder m_SessionHandler;

	protected Thread m_SendThread;

	protected Thread m_RecvThread;

	protected AutoResetEvent m_SendSignalEvent;

	protected AutoResetEvent m_RecvSignalEvent;

	protected AutoResetEvent m_NotifySendEvent;

	protected object m_CloseRequiredLock;

	protected bool m_HasCloseRequired;

	protected DisconnectedReason m_DisconnectedReason;

	public static bool SupportIPv6Only;

	protected string m_ServerAddr;

	protected int m_ServerPort;

	protected string m_ProxyServerAddr;

	protected int m_ProxyServerPort;

	protected bool m_ConnectProxy;

	public NetworkSession(ISessionHanlder cb = null)
	{
	}

	public virtual bool IsConnected()
	{
		return false;
	}

	public bool Connect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	public void Update()
	{
	}

	public void Close(bool isSendNotification = true)
	{
	}

	public virtual void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0)
	{
	}

	public virtual void SetKeepAliveInterval(double interval)
	{
	}

	public virtual void OnApplicationPause(bool paused)
	{
	}

	protected void RequestCloseSession(DisconnectedReason reason = DisconnectedReason.Unknown)
	{
	}

	protected virtual bool OnConnect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	protected virtual void OnUpdate()
	{
	}

	protected virtual void OnClose()
	{
	}

	protected void CreateRecvThread(ThreadStart threadFunc)
	{
	}

	protected void CreateSendThread(ThreadStart threadFunc)
	{
	}

	protected ulong ServerIpPortToUint64()
	{
		return 0uL;
	}
}
