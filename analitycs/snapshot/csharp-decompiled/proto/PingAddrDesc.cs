using ProtoBuf;

namespace proto;

public class PingAddrDesc : IMessage
{
	public string tcp_ip;

	public bool is_traceroute;

	public string udp_ip_port;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
