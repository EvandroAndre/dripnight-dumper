namespace proto;

public class CreditScoreChangeInfo
{
	public ulong change_time;

	public uint reason_id;

	public int credit_score_delta;

	public uint credit_score_after_change;

	public bool is_exempt;
}
