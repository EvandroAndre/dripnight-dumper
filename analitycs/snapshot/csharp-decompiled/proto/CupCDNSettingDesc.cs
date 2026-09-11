using ProtoBuf;

namespace proto;

public class CupCDNSettingDesc : IMessage
{
	public uint cup_type;

	public uint cup_id;

	public bool is_animation_open;

	public string preview_resource;

	public string lobby_resource;

	public string homepage_resource;

	public bool is_notice_open;

	public string notice_cdn1;

	public string notice_cdn2;

	public string notice_cdn3;

	public string notice_cdn4;

	public string notice_cdn5;

	public uint go_pos1;

	public uint sub_pos1;

	public uint go_pos2;

	public uint sub_pos2;

	public uint go_pos3;

	public uint sub_pos3;

	public uint go_pos4;

	public uint sub_pos4;

	public uint go_pos5;

	public uint sub_pos5;

	public string reward_resource;

	public bool full_screen_preheat_display;

	public string full_screen_preheat_resource;

	public string login_animation_resource;

	public string language;

	public string lobby_icon_resource;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
