using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetEPInfoRes : IMessage
{
	public bool owned_pass;

	public List<RewardStatus> rewards;

	public List<ChallengeStatus> challenges;

	public uint ep_event_id;

	public long start_time;

	public long end_time;

	public uint ep_badge;

	public uint gold_limit_improved;

	public uint fp_challenge_item;

	public bool owned_fp_challenge;

	public uint purchase_badge_count_today;

	public uint week;

	public long daily_reset_time;

	public uint epid_preorder;

	public long ep_preorder_start_time;

	public long ep_preorder_end_time;

	public uint daily_challenge_completed_cnt;

	public uint elite_challenge_completed_cnt;

	public uint veteran_challenge_completed_cnt;

	public long subscription_start_time;

	public long subscription_end_time;

	public uint purchase_ep_count;

	public uint ep_max_reward_claimed_badge;

	public List<DailyQuestRewardsStatus> daily_rewards_status;

	public List<WeeklyProcess> weekly_process;

	public DailyProcess daily_process;

	public List<EPDailyProcessRewardDesc> daily_process_reward_desc;

	public uint customized_discount;

	public BooyahPass.BPUnlockStatus unlock_status;

	public uint exp;

	public uint cycle_reward_claimed_times;

	public uint current_pass_status;

	public uint refresh_challenge_cnt;

	public bool is_repurchase_discount;

	public List<RankingTaskInfo> br_ranking_tasks;

	public List<CSRankingTaskInfo> cs_ranking_tasks;

	public uint gainedExpByShare;

	public uint todaySendCnt;

	public uint todayClaimCnt;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public void SetExpShareInfo(uint exp, uint sendCnt, uint claimCnt)
	{
	}
}
