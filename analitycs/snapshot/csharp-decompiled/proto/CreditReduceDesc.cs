using ProtoBuf;

namespace proto;

public class CreditReduceDesc : IMessage
{
	public ECreditScore.ReportType report_type;

	public uint behavior_rule_id;

	public uint credit_reduce;

	public bool ignore_extra_punish;

	public uint main_report_type;

	public uint credit_punish_times;

	public uint extra_credit_reduce;

	public uint credit_reduce_max;

	public uint reporter_cnt;

	public uint violation_rate;

	public uint backtracking_day_cnt;

	public uint backtracking_match_cnt_limit;

	public uint rank_sort;

	public bool only_in_game;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
