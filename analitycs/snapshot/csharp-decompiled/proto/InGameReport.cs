namespace proto;

public class InGameReport
{
	public ECreditScore.ReportType report_type;

	public ulong[] reported_account_ids;

	public bool ignore_reporter_cnt;
}
