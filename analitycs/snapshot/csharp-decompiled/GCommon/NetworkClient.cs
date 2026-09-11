namespace GCommon;

public class NetworkClient
{
	protected INetworkSession m_Session;

	protected NetworkMessageDispatcher m_MessageDispatcher;

	public void SetEnableSimpleInvokeExceptionInfo(bool b)
	{
	}

	public bool Connect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false)
	{
		return false;
	}

	public virtual void Close(bool isSendNotification = true)
	{
	}

	public bool IsConnected()
	{
		return false;
	}

	public void RegisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
	{
	}

	public void UnregisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
	{
	}

	public void RegisterFrameEndHandler(uint cmd, NetworkMessageDispatcher.NetworkMessageDelayHandler handler)
	{
	}

	protected void RegisterSession(INetworkSession sess)
	{
	}
}
