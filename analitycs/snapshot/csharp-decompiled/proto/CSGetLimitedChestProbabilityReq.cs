namespace proto;

public class CSGetLimitedChestProbabilityReq
{
	public uint chest_id;

	public uint chest_sub_id;

	public uint rare_prize_id;

	public uint super_rare_prize_id;

	public ProbabilityType probability_type;

	public bool is_open;

	public string probability_group;
}
