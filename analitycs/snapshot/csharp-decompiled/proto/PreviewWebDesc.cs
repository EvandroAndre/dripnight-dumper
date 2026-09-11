using ProtoBuf;

namespace proto;

public class PreviewWebDesc : IMessage
{
	public uint item_id;

	public string web_icon;

	public string language;

	public string web_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
