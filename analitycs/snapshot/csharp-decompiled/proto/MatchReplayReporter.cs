namespace proto;

public class MatchReplayReporter
{
	public ulong account_id;

	public string nickname;

	public ECreditScore.ReportType report_type;

	public uint reporter_time_ms;

	public uint main_reason;

	public uint[] sub_reason;
}
