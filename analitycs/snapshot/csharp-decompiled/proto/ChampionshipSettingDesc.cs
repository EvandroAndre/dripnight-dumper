using ProtoBuf;

namespace proto;

public class ChampionshipSettingDesc : IMessage
{
	public uint championship_type;

	public uint championship_id;

	public string trial_match_name;

	public uint trial_match_num;

	public uint trial_match_choose_num;

	public uint final_match_choose_num;

	public uint min_match_num;

	public uint limited_item_type;

	public uint limited_item_id;

	public uint limited_item_num;

	public uint seniority_list;

	public string clan_icon_id;

	public bool is_animation_open;

	public string login_animation_resource;

	public string lobby_resource;

	public string homepage_resource;

	public string mode_name;

	public bool is_result_ani_open;

	public bool is_notice_open;

	public string notice_cdn1;

	public string notice_cdn2;

	public string notice_cdn3;

	public string notice_cdn4;

	public bool senior_team_only;

	public uint team_scale_type;

	public uint game_mode;

	public bool disable_weapon_skin;

	public bool is_replay_on;

	public string preview_resource;

	public uint go_pos1;

	public uint sub_pos1;

	public uint go_pos2;

	public uint sub_pos2;

	public uint go_pos3;

	public uint sub_pos3;

	public uint go_pos4;

	public uint sub_pos4;

	public string notice_cdn5;

	public uint go_pos5;

	public uint sub_pos5;

	public uint leaderboard_local_size;

	public string language;

	public string background_resource;

	public string lobby_icon_resource;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
