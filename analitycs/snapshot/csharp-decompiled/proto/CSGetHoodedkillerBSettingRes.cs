using System.Collections.Generic;

namespace proto;

public class CSGetHoodedkillerBSettingRes
{
	public HoodedkillerBSettingDesc setting;

	public List<HoodedkillerBMissionDesc> missions;

	public List<HoodedkillerBTargetResourceDesc> resources;

	public List<HoodedkillerBRewardDesc> rewards;
}
