using System.Collections.Generic;

namespace proto;

public class WorkshopLeaderboardBasicInfo
{
	public string leaderboard_name;

	public long create_time;

	public EWorkshop.LeaderboardOrderType order_type;

	public uint count;

	public long min_score;

	public long clear_start_time;

	public uint clear_interval_hours;

	public long last_clear_time;

	public List<DataStorageLeaderboardAwardInfo> award_infos;

	public List<WorkshopRelativeSheetHeader> relative_sheet_header;

	public List<WorkshopLeaderboardHeader> leaderboard_header;

	public bool is_account_id;

	public string relative_sheet_name;

	public List<WorkshopLeaderboardLocalizationNames> leaderboard_localization_names;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;

	public Dictionary<string, WorkshopLeaderboardRegionSettings> region_setting;
}
