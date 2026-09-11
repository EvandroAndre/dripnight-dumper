using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSClanAreaLeaderboardDescRes
{
	public class RegionDesc : IMessage
	{
		public string region;

		public ClanLeaderboardSettingsDesc settings;

		public List<ClanLeaderboardAreaListDesc> areas;

		public List<ClanAreaLeaderboardDesc> leaderboards;

		public void ParseFrom(ProtoReader reader)
		{
		}
	}

	public List<GuildWarLeaderboardAwardDesc> awards;

	public List<GuildWarLeaderboardTitleDesc> titles;

	public List<RegionDesc> region_desc;
}
