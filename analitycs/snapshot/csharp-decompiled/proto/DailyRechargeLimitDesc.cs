using ProtoBuf;

namespace proto;

public class DailyRechargeLimitDesc : IMessage
{
	public string region;

	public EAntiAddiction.AgeState age;

	public uint daily_recharge_limit;

	public string refresh;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
