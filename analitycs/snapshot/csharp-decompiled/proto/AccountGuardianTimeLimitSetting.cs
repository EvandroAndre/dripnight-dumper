using ProtoBuf;

namespace proto;

public class AccountGuardianTimeLimitSetting : IMessage
{
	public bool init;

	public GuardianTimeLimitSetting setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
