using System.Collections.Generic;

namespace proto;

public class CSGetTeamUpRecommendRes
{
	public List<AccountInfoBasic> accounts;

	public uint[] common_friend_nums;

	public uint recommend_source;

	public List<RankingStatsSummary> ranking_stats;
}
