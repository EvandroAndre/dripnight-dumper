using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetCurrentOrRecentRankingSeasonConfigRes : IMessage
{
	public RankingSeasonInfo season_info;

	public List<RankAwardsDesc> awards;

	public List<RankTopAwardsDesc> top_awards_with_level;

	public List<RankingAwardExhibitDesc> award_exhibit;

	public InvalidRankingLeaderboardParam leaderboard_param;

	public List<BRFirstRankRewardsDesc> first_rank_rewards;

	public uint min_leaderboard_score;

	public List<RankingWinPassDesc> win_pass;

	public List<RankingWinPassDesc> next_win_pass;

	public List<RankingMultiModeBonusDesc> multi_mode_bonus;

	public List<BRRankBonusPointActivitiesDesc> bonus_point_activities;

	public BRRatingRankUpgradeDesc rating_rank_upgrade;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
