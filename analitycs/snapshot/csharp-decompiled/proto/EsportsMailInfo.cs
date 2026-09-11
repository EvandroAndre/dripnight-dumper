using ProtoBuf;

namespace proto;

public class EsportsMailInfo : IMessage
{
	public string esports_name;

	public string award_name;

	public string award_description;

	public uint rank;

	public string deep_link;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
