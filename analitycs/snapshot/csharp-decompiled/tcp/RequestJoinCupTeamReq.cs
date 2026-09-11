namespace tcp;

public class RequestJoinCupTeamReq
{
	public ulong applicant_id;

	public uint cup_type;

	public uint cup_id;

	public uint applicant_tier;

	public CupGroupMemberInfo group_member_info;
}
