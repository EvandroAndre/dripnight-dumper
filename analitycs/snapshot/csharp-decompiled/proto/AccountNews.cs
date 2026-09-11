using ProtoBuf;

namespace proto;

public class AccountNews : IMessage
{
	public EAccount.NewsType type;

	public AccountNewsContent content;

	public long update_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
