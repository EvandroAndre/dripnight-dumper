using GCommon;
using proto;
using tcp;

namespace COW;

internal class ServiceConnectionHandler : ISessionHanlder, ISessionMonitor
{
	protected class ReconnectInfo
	{
		public bool NeedReconnected;

		public float NextReconnectTime;

		public int ReconnectCount;

		public string LogTag;

		public void TryReconnect()
		{
		}

		public void Reset(bool isDeep)
		{
		}
	}

	protected ServiceClient2 m_Client;

	protected string m_Addr;

	protected int m_Port;

	public bool m_IsConfirmed;

	protected ReconnectInfo m_ReconnectInfo;

	protected bool m_NeedLogout;

	protected tcp.EAccount.Proto m_DisconnectByServerReason;

	protected string m_LogTag;

	public uint DisconnectCount;

	public string m_Token;

	protected AntiAddicHistoryInfo m_AntiAddicHistoryInfo;

	public bool IsQuickReconnecting;

	protected bool m_HasEverConfirmed;

	private AccessValidInfo m_AccessValidInfo;

	public ServiceConnectionHandler(string token, string logTag, AntiAddicHistoryInfo antiAddicHistoryInfo, AccessValidInfo accessValidInfo)
	{
	}

	public void Connect()
	{
	}

	public bool Connect(string addr, int port)
	{
		return false;
	}

	public virtual void OnConnected(bool result)
	{
	}

	public void QuickReconnect()
	{
	}

	public void Update(float gameTime)
	{
	}

	public void Close()
	{
	}

	public void Destroy()
	{
	}

	public virtual void OnPingSent(int lastSentTime)
	{
	}

	public virtual void OnPingReceiveTimeout()
	{
	}

	public virtual void OnReconnect()
	{
	}

	public void OnDisconnected(DisconnectedReason reason = DisconnectedReason.Unknown)
	{
	}

	public virtual void OnDisconnected(tcp.EAccount.Proto reason)
	{
	}

	protected virtual void OnServerConfirmed(TCPEmptyMessage res)
	{
	}

	public static T MessageNotifyContentUnSerializeObject<T>(MessageNotify msg)
	{
		return default(T);
	}

	public void SendAntiAddictionInfo(tcp.EAntiAddiction.Proto proto)
	{
	}

	public bool IsConfirmed()
	{
		return false;
	}

	public bool Send(EProtocol.Proto cmdType, ProtoReq message, byte regionID = 0)
	{
		return false;
	}

	public string CheckProtoType(EProtocol.Proto cmd, uint res_cmd)
	{
		return null;
	}

	public bool NeedLogout()
	{
		return false;
	}

	public tcp.EAccount.Proto GetDisconnectionReason()
	{
		return tcp.EAccount.Proto.Proto_NONE;
	}

	public virtual EServiceHandler GetServiceHandlerName()
	{
		return EServiceHandler.None;
	}

	public void OnApplicationPause(bool paused)
	{
	}

	public bool OnHandlePacket(TCPMsgPacket tcpPacket, object tcpMsg)
	{
		return false;
	}

	public void SetServiceClientMsgHandleMode(EMsgHandleMode mode)
	{
	}
}
