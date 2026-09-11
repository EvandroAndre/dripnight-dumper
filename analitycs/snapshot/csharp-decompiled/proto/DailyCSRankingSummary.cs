using System.Collections.Generic;

namespace proto;

public class DailyCSRankingSummary
{
	public class match
	{
		public ulong match_id;

		public uint rank_star;

		public uint season_id;

		public long end_at;

		public uint pre_rank_star;

		public uint rank;

		public uint pre_rank;

		public uint rank_points;

		public uint pre_rank_points;
	}

	public List<match> match_list;
}
