using System.Collections.Generic;

namespace proto;

public class CSWeaponPowerLeaderboardAreaChooseRes
{
	public uint area_id;

	public long choose_area_time;

	public List<WeaponPowerLeaderboardInfo> leaderboards;

	public List<AreaLeaderboardInfo> area_leaderboards;
}
