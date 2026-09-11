using ProtoBuf;

namespace proto;

public class MailGlobalDropInfo : IMessage
{
	public uint item_id;

	public string url;

	public uint award_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
