using ProtoBuf;

namespace proto;

public class CSAntiHackCenterDescRes : IMessage
{
	public AntiHackCenterDesc anti_hack_center_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
