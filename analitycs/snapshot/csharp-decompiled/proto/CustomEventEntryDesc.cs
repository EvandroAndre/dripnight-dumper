using ProtoBuf;

namespace proto;

public class CustomEventEntryDesc : IMessage
{
	public uint event_id;

	public uint entry_id;

	public string start_time;

	public string end_time;

	public uint start_timestamp;

	public uint end_timestamp;

	public string entry_icon;

	public string title;

	public string go_pos;

	public string web_url;

	public string is_main_activity;

	public string cdn_image;

	public string award_icon;

	public string title_cdn;

	public string award_bg_cdn;

	public string title_language;

	public bool is_push_show;

	public string sub_go_pos;

	public uint useType;

	private void OnConstructor()
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
