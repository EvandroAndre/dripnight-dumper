using ProtoBuf;

namespace tcp;

public class AccountIDCPingInfo : IMessage
{
	public string idc;

	public int ping;

	public string lock_region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
