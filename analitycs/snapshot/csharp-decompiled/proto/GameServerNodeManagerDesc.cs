using ProtoBuf;

namespace proto;

public class GameServerNodeManagerDesc : IMessage
{
	public string region;

	public string node_name;

	public string server_ip;

	public bool is_default;

	public uint warn_capacity;

	public string lock_region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
