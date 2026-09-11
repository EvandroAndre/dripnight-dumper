using System.Collections.Generic;

namespace proto;

public class CSGetCSPeakLeaderboardInfoRes
{
	public uint area_id;

	public long choose_area_time;

	public CSPeakAreaLeaderboardInfoWithTitle area_leaderboard_info;

	public List<CSPeakPlayerTitleInfo> region_titles;

	public bool is_first_title_receive;

	public bool is_season_title_receive;

	public bool change_area_after_season_end;
}
