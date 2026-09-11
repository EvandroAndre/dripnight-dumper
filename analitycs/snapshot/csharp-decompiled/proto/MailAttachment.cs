using ProtoBuf;

namespace proto;

public class MailAttachment : IMessage
{
	public AwardData rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
