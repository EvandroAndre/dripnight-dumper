using ProtoBuf;

namespace proto;

public class AdvertDesc : IMessage
{
	public uint id;

	public uint type;

	public uint sort_id;

	public string language;

	public string advertisment_url;

	public uint ad_start_time;

	public uint ad_end_time;

	public uint go_pos;

	public uint sub_type;

	public string sub_go_pos;

	public bool external_for_official_website;

	public bool go_to_switch;

	public uint small_start_time;

	public uint show_end_time;

	public uint group_id;

	public bool is_effect;

	public uint banner_tag_id;

	public uint value;

	public bool is_prime;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
