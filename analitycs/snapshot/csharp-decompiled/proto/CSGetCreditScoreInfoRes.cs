using System.Collections.Generic;

namespace proto;

public class CSGetCreditScoreInfoRes
{
	public ulong account_id;

	public uint credit_score;

	public bool is_init;

	public ECreditScore.RewardState reward_state;

	public uint periodic_summary_like_cnt;

	public uint periodic_summary_illegal_cnt;

	public uint weekly_match_cnt;

	public long periodic_summary_start_time;

	public long periodic_summary_end_time;

	public ECreditScore.SummaryLevel periodic_summary_level;

	public List<CreditPunishOtherInfo> credit_punish_other_info;

	public PhotoWallReportInfo photo_wall_report_info;
}
