namespace proto;

public class SpecialModeOpeningInfoDesc
{
	public uint special_mode_event_id;

	public uint match_mode;

	public uint game_mode;

	public bool is_open;

	public long start_time;

	public long end_time;

	public uint special_mode_config_id;

	public string title_key;

	public string cdn_link;

	public string icon_res;

	public uint protect_times;

	public uint rank_limit;

	public uint default_state;

	public long normal_match_time;

	public long hacker_match_time;

	public long emulator_match_time;

	public uint rank_sort_id_limit;

	public bool display_no_interact;

	public bool is_bot_open;

	public uint event_open_id;

	public string affixes_description_key;

	public uint[] lobby_display_affixes;

	private uint[] m_FilteredLobbyDisplayAffixes;

	public uint[] GetLobbyDisplayAffixes()
	{
		return null;
	}
}
