using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSWeaponPowerLeaderboardDescRes : IMessage
{
	public class RegionDesc : IMessage
	{
		public string region;

		public WeaponPowerLeaderboardSettingsDesc settings;

		public List<WeaponPowerLeaderboardAreaListDesc> areas;

		public List<WeaponPowerLeaderboardDesc> leaderboards;

		public void ParseFrom(ProtoReader reader)
		{
		}
	}

	public List<WeaponPowerLeaderboardAwardDesc> awards;

	public List<WeaponPowerLeaderboardTitleDesc> titles;

	public List<WeaponPowerSwitchDesc> switches;

	public WeaponPowerSettingDesc weapon_power_setting;

	public List<RegionDesc> region_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
