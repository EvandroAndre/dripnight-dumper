using System.Collections.Generic;

namespace proto;

public class CSGetChampionshipConfigRes
{
	public ChampionshipOpenInfoDesc open_info;

	public List<ChampionshipScoreRewardDesc> reward_infos;

	public ChampionshipSettingDesc setting_info;
}
