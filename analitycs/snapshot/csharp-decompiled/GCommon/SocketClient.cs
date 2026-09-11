using System.Net;
using System.Net.Sockets;

namespace GCommon;

public class SocketClient
{
	private const int RECV_BUFF_SIZE = 512000;

	private const int SEND_BUFF_SIZE = 128000;

	private UdpClient m_UDPClient;

	private TcpClient m_TCPClient;

	private bool useUDP;

	private byte[] m_TCPSendBuffer;

	public SocketClient Client => null;

	public int Available => 0;

	public SocketClient(bool udp = true)
	{
	}

	public void CreateUDPSocket(IPEndPoint endPoint, IPAddress localAddr = null)
	{
	}

	public bool BindUDPSocket(int networkType)
	{
		return false;
	}

	public bool ConnectUDPSocket(IPEndPoint endPoint)
	{
		return false;
	}

	public bool Connect(IPEndPoint endPoint, IPAddress localAddr = null)
	{
		return false;
	}

	public void Close()
	{
	}

	public Socket Socket()
	{
		return null;
	}

	public int Receive(byte[] buffer)
	{
		return 0;
	}

	public void Send(byte[] buffer, int len)
	{
	}
}
