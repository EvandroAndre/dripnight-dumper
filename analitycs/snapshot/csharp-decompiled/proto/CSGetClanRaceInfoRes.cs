using System.Collections.Generic;

namespace proto;

public class CSGetClanRaceInfoRes
{
	public uint stage;

	public bool is_open;

	public List<ClanRaceRewardsDesc> rewards;

	public uint race_point;

	public uint latest_race_week_id;

	public List<RaceAwardExchange> exchange_info;

	public ClanRaceOpenInfo clan_race_open_info;
}
