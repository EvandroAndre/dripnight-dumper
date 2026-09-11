using ProtoBuf;

namespace proto;

public class CustomEventLocDesc : IMessage
{
	public uint loc_id;

	public string language;

	public string content;

	public string color;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
