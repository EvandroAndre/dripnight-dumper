using ProtoBuf;

namespace proto;

public class ActivityFestivalDesc : IMessage
{
	public uint event_id;

	public uint table_type;

	public string table_sprite;

	public string language;

	public string event_title;

	public string event_lobby_icon;

	public string start_time;

	public string end_time;

	public uint festival_item_id;

	public string cdn_url;

	public uint affiliate_table;

	public uint group_id;

	public string color_value;

	public string select_line;

	public string event_lobby_vfx;

	public uint leave_days;

	public uint feature_period_time;

	public uint max_features;

	public long patch_note_top_time;

	public string icon_cdn_url;

	public uint sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
