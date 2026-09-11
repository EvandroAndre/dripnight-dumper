using System;
using System.Collections.Generic;

namespace GCommon;

public class NetworkMessageDispatcher
{
	public delegate void NetworkMessageHandler<T>(T arg);

	public delegate void NetworkMessageDelayHandler();

	private bool m_isTcpDispatcher;

	private Dictionary<uint, NetworkMessageHandlerPair> m_FrameEndHandlers;

	private Dictionary<uint, NetworkMessageHandlerPair> m_Handlers;

	private Dictionary<uint, string> m_InvokeExceptionCmds;

	private bool m_EnableSimpleInvokeExceptionInfo;

	private object[] m_Param;

	public bool EnableSimpleInvokeExceptionInfo
	{
		set
		{
		}
	}

	public NetworkMessageDispatcher(bool isTcpDispatcher = true)
	{
	}

	public void RegisterHandler<T>(uint cmd, NetworkMessageHandler<T> handler)
	{
	}

	public void RegisterFrameEndHandler(uint cmd, NetworkMessageDelayHandler handler)
	{
	}

	public void UnregisterHandlers(uint cmd)
	{
	}

	public void UnregisterHandler<T>(uint cmd, NetworkMessageHandler<T> handler)
	{
	}

	public void Clear()
	{
	}

	public Type GetCmdType(uint cmd)
	{
		return null;
	}

	public void Invoke(uint cmd, object msg)
	{
	}

	public void InvokeAtFrameEnd(HashSet<uint> cmds)
	{
	}

	public bool IsCmdInvokeAtFrameEnd(uint cmd)
	{
		return false;
	}
}
