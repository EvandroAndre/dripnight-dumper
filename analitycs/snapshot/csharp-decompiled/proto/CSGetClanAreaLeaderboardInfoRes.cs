using System.Collections.Generic;

namespace proto;

public class CSGetClanAreaLeaderboardInfoRes
{
	public uint area_id;

	public long choose_area_time;

	public List<GuildWarPlayerTitleInfo> titles;

	public List<ClanAreaLeaderboardInfo> leaderboards;

	public bool area_id_delete;
}
