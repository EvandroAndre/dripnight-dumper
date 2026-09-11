using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RegionLeaderboardAreaDesc
{
	public class RegionDesc : IMessage
	{
		public string region;

		public AreaLeaderboardSettingDesc settings;

		public List<LeaderboardAreaListDesc> areas;

		public void ParseFrom(ProtoReader reader)
		{
		}
	}

	public List<RegionDesc> region_area_desc;
}
