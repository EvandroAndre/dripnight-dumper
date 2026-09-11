namespace proto;

public class FFWSMatchDesc
{
	public uint id;

	public uint match_score_lower_bound;

	public uint match_score_upper_bound;

	public uint sword_difficulty_lower_bound;

	public uint sword_difficulty_upper_bound;

	public uint policy_difficulty_lower_bound;

	public uint policy_difficulty_upper_bound;

	public uint[] weight;

	public long start_time;

	public long end_time;
}
