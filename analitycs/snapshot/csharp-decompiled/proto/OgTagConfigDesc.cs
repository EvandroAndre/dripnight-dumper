using ProtoBuf;

namespace proto;

public class OgTagConfigDesc : IMessage
{
	public uint num_id;

	public string start_time;

	public string end_time;

	public long start_timestamp;

	public long end_timestamp;

	public string tag_res;

	public string tag_banner_res;

	public string full_screen_res;

	public string full_screen_cdn;

	public string congrat_cdn;

	public string full_screen_banner;

	public OgTagType tag_type;

	public string tag_bg_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
