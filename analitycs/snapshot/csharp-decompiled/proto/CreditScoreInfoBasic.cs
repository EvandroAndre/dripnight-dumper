using ProtoBuf;

namespace proto;

public class CreditScoreInfoBasic : IMessage
{
	public uint credit_score;

	public bool is_init;

	public ECreditScore.RewardState reward_state;

	public uint periodic_summary_like_cnt;

	public uint periodic_summary_illegal_cnt;

	public uint weekly_match_cnt;

	public long periodic_summary_start_time;

	public long periodic_summary_end_time;

	public ECreditScore.SummaryLevel periodic_summary_level;

	public PhotoWallReportInfo photo_wall_report_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
