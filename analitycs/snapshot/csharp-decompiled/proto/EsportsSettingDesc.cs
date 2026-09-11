namespace proto;

public class EsportsSettingDesc
{
	public long match_start_prepare_room_time;

	public long create_room_time;

	public long round_time;

	public uint max_round_num;

	public uint max_match_show_num;

	public uint max_team_show_num;

	public uint min_start_player;

	public uint ban_player_num;

	public uint anti_hack_time;

	public uint max_join_requests_num;

	public uint max_send_join_requests_num;

	public uint max_slogan_length;

	public uint no_show_punish_seconds;

	public uint esports_history_show_num;

	public uint review_approval_deadline_seconds;

	public uint min_teams_per_room_solo;

	public uint max_teams_per_room_solo;

	public uint min_teams_per_room_quad;

	public uint max_teams_per_room_quad;

	public string push_event_deep_link;

	public uint valid_kill_max;

	public uint daily_invite_num;

	public long checkin_duration;
}
