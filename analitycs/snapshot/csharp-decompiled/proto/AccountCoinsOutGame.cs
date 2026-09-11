using ProtoBuf;

namespace proto;

public class AccountCoinsOutGame : IMessage
{
	public uint coins_weekly;

	public long next_refresh_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
