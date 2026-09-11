using System.Collections.Generic;

namespace tcp;

public class RankingWarmMatchInfo
{
	public uint today_warm_cnt;

	public uint streak_lose;

	public uint season_id;

	public uint season_warm_cnt;

	public long last_update_time;

	public uint streak_win;

	public uint veteran_warm_cnt;

	public uint seven_day_match_cnt;

	public uint seven_day_match_survival_time;

	public List<TodayMatchRecord> today_match_record;

	public uint today_land_fight_warm_cnt;

	public uint ai_match_cooldown;
}
