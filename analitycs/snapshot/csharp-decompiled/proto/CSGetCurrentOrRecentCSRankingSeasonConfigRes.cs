using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCurrentOrRecentCSRankingSeasonConfigRes : IMessage
{
	public CSRankingSeasonInfoDesc season_info;

	public List<CSRankAwardsDesc> awards;

	public List<CSRankTopAwardsDesc> top_awards_with_level;

	public List<CSRankingAwardExhibitDesc> award_exhibit;

	public CSRankingParamDesc ranking_params;

	public List<CSProtectionDesc> protections;

	public List<CSFirstRankRewardsDesc> first_rank_rewards;

	public uint min_leaderboard_score;

	public List<RankingWinPassDesc> win_pass;

	public List<RankingWinPassDesc> next_win_pass;

	public List<CSRankingMultiModeBonusDesc> multi_mode_bonus;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
