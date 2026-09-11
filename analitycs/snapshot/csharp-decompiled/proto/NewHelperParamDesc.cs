using ProtoBuf;

namespace proto;

public class NewHelperParamDesc : IMessage
{
	public bool is_open;

	public bool is_high_light_open;

	public bool is_match_review_open;

	public bool is_daily_report_open;

	public uint daily_report_show_least_match_cnt;

	public uint high_light_show_least_match_cnt;

	public uint br_min_calibration;

	public uint cs_min_calibration;

	public uint[] user_ab_test_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
