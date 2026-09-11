using ProtoBuf;

namespace proto;

public class RecruitVarDesc : IMessage
{
	public bool is_open;

	public long open_start_time;

	public bool exclude_ip_regions_is_open;

	public long regions_open_start_time;

	public uint max_tag_num;

	public uint max_team_num;

	public uint auto_refresh_cd;

	public uint manual_refresh_cd;

	public uint client_filter_cd;

	public uint[] game_modes;

	public uint[] match_modes;

	public uint[] group_modes;

	public uint[] mode_weight;

	public bool is_quick_join_open;

	public bool in_group_quick_join;

	public uint all_mode_group_num;

	public uint[] newbie_recruit_switch;

	public uint[] rookie_recruit_switch_level;

	public uint afk_judgment_time;

	public uint recruit_penalty_time;

	public uint recruit_violation_num;

	public uint recruit_violation_time;

	public uint recruit_quick_change_cd;

	public uint[] channel_whitelist;

	public uint change_team_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
