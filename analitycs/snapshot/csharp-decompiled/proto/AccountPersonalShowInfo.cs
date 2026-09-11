using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AccountPersonalShowInfo : IMessage
{
	public AccountInfoBasic basic_info;

	public AvatarProfile profile_info;

	public int ranking_leaderboard_pos;

	public List<AccountNews> news;

	public List<BasicEPInfo> history_ep_info;

	public ClanInfoBasic clan_basic_info;

	public AccountInfoBasic captain_basic_info;

	public PetInfo pet_info;

	public SocialBasicInfo social_info;

	public DiamondCostRes diamond_cost_res;

	public CreditScoreInfoBasic credit_score_info;

	public EAttendance.PreVeteranActionType pre_veteran_type;

	public List<AccountMMRInfo> mmr_list;

	public ModeStatsSummaryInfo mode_stats_summary_info;

	public SparkInfo user_spark_info;

	public SparkInfo collab_spark_info;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
