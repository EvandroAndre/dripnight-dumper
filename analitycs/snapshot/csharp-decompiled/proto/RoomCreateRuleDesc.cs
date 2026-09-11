namespace proto;

public class RoomCreateRuleDesc
{
	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public uint[] members;

	public uint[] spectators;

	public uint room_type;

	public uint min_member_cnt;

	public bool enable_voice_chat;

	public uint[] enter_level_limit;

	public bool enable_room_afk;

	public bool enable_score_board;

	public bool enable_in_game_voice;

	public uint id;

	public uint show_win;
}
