using ProtoBuf;

namespace proto;

public class VoicePackageDesc : IMessage
{
	public uint item_id;

	public string bundle_cdn_link;

	public string uifx_color;

	public string color_set;

	public string item_cdn_link;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
