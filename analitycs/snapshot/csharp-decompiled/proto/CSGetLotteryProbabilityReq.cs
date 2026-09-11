namespace proto;

public class CSGetLotteryProbabilityReq
{
	public uint chest_id;

	public uint chest_sub_id;

	public ProbabilityType probability_type;

	public bool is_open;

	public uint[] rounds;

	public string probability_group;
}
