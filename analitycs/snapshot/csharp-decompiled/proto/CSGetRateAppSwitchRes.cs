using ProtoBuf;

namespace proto;

public class CSGetRateAppSwitchRes : IMessage
{
	public RateAppSwitchDesc switch_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
