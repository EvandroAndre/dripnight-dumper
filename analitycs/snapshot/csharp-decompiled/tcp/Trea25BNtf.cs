namespace tcp;

public class Trea25BNtf
{
	public class Trea25BGridInfo
	{
		public uint state;

		public uint trea_id;

		public ulong friend_account_id;

		public string friend_nickname;
	}

	public enum NTFReason
	{
		NTFR_NONE,
		NTFR_BE_HELPED,
		NTFR_BE_ASKED_HELP
	}

	public NTFReason ntf_reason;

	public ulong account_id;

	public uint map_id;

	public int grid_index;

	public Trea25BGridInfo grid_info;

	public uint daily_be_helped_count;
}
