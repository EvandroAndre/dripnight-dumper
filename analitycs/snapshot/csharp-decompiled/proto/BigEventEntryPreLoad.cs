using ProtoBuf;

namespace proto;

public class BigEventEntryPreLoad : IMessage
{
	public string start_time;

	public string end_time;

	public string title_cdn;

	public string award_bg_cdn;

	public string cdn_image;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
