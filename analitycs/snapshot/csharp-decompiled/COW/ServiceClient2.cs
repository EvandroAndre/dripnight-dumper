using System;
using System.Collections.Generic;
using GCommon;
using LitJson;

namespace COW;

public class ServiceClient2
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ServiceClient2 _003C_003E4__this;

		public bool result;

		internal void _003COnSocketConnected_003Eb__0()
		{
		}
	}

	private TCPSession2 m_TCPSession;

	private Queue<TCPMsgPacket> m_RecvTCPMsgList;

	private string m_LogTag;

	protected NetworkMessageDispatcher m_MessageDispatcher;

	private string m_Token;

	private ISessionHanlder m_Hanlder;

	public float StartConnectTime;

	private Queue<Action> m_EventMQ;

	private EMsgHandleMode m_MsgHandleMode;

	private Dictionary<int, Dictionary<int, Type>> m_MessageSubDataTypes;

	public static bool UnserializeMessageContentInThread;

	public static JsonData BackendTcpLogJsonData;

	public ServiceClient2(string token, string tag, AccessValidInfo accessValidInfo, ISessionHanlder sessionHanlder)
	{
	}

	public void OpenUTCTime(bool state)
	{
	}

	public string ConsumeLastConnectException()
	{
		return null;
	}

	private void OnSocketConnected(bool result)
	{
	}

	private void OnTCPException()
	{
	}

	public bool Connect(string addr, int port)
	{
		return false;
	}

	public bool Send(byte cmd, byte[] data, int byteCount, byte region)
	{
		return false;
	}

	public void SetMsgHandleType(EMsgHandleMode mode)
	{
	}

	public void RegisterMessageSubDataType(int packetCmd, int messageSubCmd, Type messageSubDataType)
	{
	}

	public void Update()
	{
	}

	private void HandleRecvPacket()
	{
	}

	private void UnSerializeHandlerInThread(TCPMsgPacket packet)
	{
	}

	private void HandleMsg(TCPMsgPacket packet)
	{
	}

	public void RegisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
	{
	}

	public void Close(bool notify = false)
	{
	}

	public bool Closed()
	{
		return false;
	}

	public bool Connected()
	{
		return false;
	}

	public void OnApplicationPause(bool paused)
	{
	}

	private void _003COnTCPException_003Eb__16_0()
	{
	}
}
