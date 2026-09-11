using ProtoBuf;

namespace proto;

public class SquadTreasureSettingDesc : IMessage
{
	public uint squad_treasure_id;

	public string start_time;

	public string end_time;

	public uint squad_number;

	public uint unlock_number;

	public uint unlock_time;

	public uint squad_default_state;

	public long start_timestamp;

	public long end_timestamp;

	public uint invitations_limit;

	public uint friend_team_recommend;

	public uint clan_team_recommend;

	public uint public_team_recommend;

	public string lobby_ui_fx;

	public uint[] unlock_deadlines;

	public uint remind_time;

	public uint bubble_time;

	public string background_ui_fx;

	public string grand_prize_ui_fx;

	public uint customize_type;

	public uint group_photo_id;

	public uint free_team_create_count;

	public uint team_create_cd;

	public uint completed_teams_per_page;

	public uint friend_team_retry_max;

	public uint public_team_retry_max;

	public bool is_old_branch;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
