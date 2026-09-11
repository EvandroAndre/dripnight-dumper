using System.Collections.Generic;

namespace proto;

public class WorkshopLeaderboard
{
	public string leaderboard_name;

	public EWorkshop.LeaderboardOrderType order_type;

	public List<WorkshopLeaderboardContent> contents;

	public uint first_order_index;

	public uint last_order_index;

	public long clear_start_time;

	public uint clear_interval_hours;

	public List<DataStorageLeaderboardAwardInfo> award_infos;

	public string relative_sheet_name;

	public List<WorkshopRelativeSheetHeader> relative_sheet_header;

	public List<WorkshopLeaderboardHeader> leaderboard_header;

	public bool is_account_id;

	public List<WorkshopLeaderboardLocalizationNames> leaderboard_localization_names;

	public uint clear_interval_unit;

	public bool disable_auto_clear;

	public int timezone_offset;

	public bool timezone_set_by_player;
}
