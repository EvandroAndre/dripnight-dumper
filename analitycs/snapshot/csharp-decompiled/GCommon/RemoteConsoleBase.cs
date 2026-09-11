using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

namespace GCommon;

public class RemoteConsoleBase : MonoBehaviour
{
	public delegate void ConsoleCommand(string param);

	public static RemoteConsoleBase instance;

	private UdpClient m_UDPClient;

	private TcpClient m_TCPClient;

	private TcpListener m_TCPListener;

	private Thread m_UDPRecvThread;

	private Thread m_TCPRecvThread;

	private bool m_TCPMode;

	public int m_LocalPort;

	protected EndPoint m_ReceivedEP;

	protected EndPoint m_RemoteEP;

	private byte[] mReceiveByteData;

	private Dictionary<string, ConsoleCommand> m_ConsoleCommands;

	private Dictionary<string, string> m_ConsoleCommandsDesc;

	private Dictionary<string, string> m_ReturnValuesBox;

	private NetworkByteStream m_UdpRecvBuffer;

	private byte[] m_TCPRecvBuffer;

	private string ConnectCMD;

	private Socket mUDPServer;

	private StringBuilder m_LocalStream;

	private string m_LocalAddr;

	private List<string> _m_PendingCommands;

	protected string m_PrintIndent;

	protected int m_PrintIndentLevel;

	public bool Toggle3pPosDebug;

	public bool ToggleMUDPPing;

	public Dictionary<string, string> ConsoleCommandsDesc => null;

	public string LocalAddr => null;

	protected int PrintIndentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void InitRemoteConsoleServer()
	{
	}

	public void InitUDPClient()
	{
	}

	public void InitTCPListener()
	{
	}

	private void AcceptCallback(IAsyncResult ar)
	{
	}

	private void OnTcpReceiveThread()
	{
	}

	private void OnRecvDataThread()
	{
	}

	public void UpdatePendingCommands()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDestory()
	{
	}

	public void Send(string msg)
	{
	}

	private void ThreadSafeAddPendingCommand(string s)
	{
	}

	private void ThreadSafeExecutePendingCommands()
	{
	}

	protected virtual void ExecuteCommand(string cmdline)
	{
	}

	public string ExecuteCommandLocalCall(string cmd)
	{
		return null;
	}

	private static void ReceiveCallback(IAsyncResult ar)
	{
	}

	public void DefCommand(string cmdStr, ConsoleCommand cmd, string description = "")
	{
	}

	protected virtual void InitializeConsoleCommands()
	{
	}

	private void CmdPing(string param)
	{
	}

	private void CmdList(string param)
	{
	}

	private void CmdConnect(string param)
	{
	}

	protected void CmdSetStatic(string param)
	{
	}

	private void CmdGetStatic(string param)
	{
	}

	private object ParseValue(Type fType, string valueStr)
	{
		return null;
	}

	private void CmdCallStatic(string param)
	{
	}

	public void Print(string s)
	{
	}

	public void PrintTransforms(Transform t, bool rec = true)
	{
	}

	protected void PrintTransform(Transform t)
	{
	}

	public void SetNetworkMode(bool isTCP)
	{
	}

	public bool IsTCP()
	{
		return false;
	}

	public string GetReturnValue(string cmd)
	{
		return null;
	}

	public void SetReturnValue(string cmd, string value)
	{
	}
}
