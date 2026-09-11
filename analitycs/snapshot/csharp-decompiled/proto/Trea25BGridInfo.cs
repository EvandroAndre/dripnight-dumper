namespace proto;

public class Trea25BGridInfo
{
	public enum EGridState
	{
		GS_COVERED,
		GS_COVERED_DOUBLE,
		GS_MINED,
		GS_CLAIMED
	}

	public EGridState state;

	public uint trea_id;

	public bool is_obstacle;

	public ulong friend_account_id;

	public string friend_nickname;

	public uint mining_times;

	public uint probability;
}
