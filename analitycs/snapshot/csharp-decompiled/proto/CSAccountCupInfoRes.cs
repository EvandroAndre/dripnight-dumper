namespace proto;

public class CSAccountCupInfoRes
{
	public ulong account_id;

	public uint cup_type;

	public uint cup_id;

	public uint tier;

	public CupTeamInfo team_info;

	public ulong team_id;

	public bool award_claimed;

	public bool use_ticket;

	public uint member_type;

	public ulong join_at;
}
