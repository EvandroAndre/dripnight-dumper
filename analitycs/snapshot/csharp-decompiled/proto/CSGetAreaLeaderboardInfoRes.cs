namespace proto;

public class CSGetAreaLeaderboardInfoRes
{
	public uint area_id;

	public long choose_area_time;

	public CSWeaponPowerLeaderboardInfoRes weapon_power_leaderboard_info;

	public CSGetClanAreaLeaderboardInfoRes clan_area_leaderboard_info;

	public AreaLeaderboardInfoWithTitle area_leaderboard_info;

	public CSGetCSPeakLeaderboardInfoRes cs_peak_leaderboard_info;

	public bool area_id_delete;

	public long choose_area_next_effect_time;
}
