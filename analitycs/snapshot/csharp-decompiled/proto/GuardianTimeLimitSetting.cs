using ProtoBuf;

namespace proto;

public class GuardianTimeLimitSetting : IMessage
{
	public bool unlimited;

	public long time_limit_seconds;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
