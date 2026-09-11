using System.Collections.Generic;

namespace proto;

public class CSWeaponPowerLeaderboardInfoRes
{
	public uint area_id;

	public long choose_area_time;

	public List<WeaponPowerPlayerTitleInfo> titles;

	public List<WeaponPowerLeaderboardInfo> leaderboards;
}
