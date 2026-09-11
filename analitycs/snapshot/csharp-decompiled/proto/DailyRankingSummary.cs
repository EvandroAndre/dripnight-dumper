using System.Collections.Generic;

namespace proto;

public class DailyRankingSummary
{
	public class match
	{
		public ulong match_id;

		public uint rank_points;

		public uint season_id;

		public long end_at;

		public uint pre_rank_points;
	}

	public List<match> match_list;
}
