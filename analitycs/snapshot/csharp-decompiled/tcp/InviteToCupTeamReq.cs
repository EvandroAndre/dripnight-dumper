namespace tcp;

public class InviteToCupTeamReq
{
	public ulong inviter_id;

	public string inviter_name;

	public ulong cup_team_id;

	public string cup_team_name;

	public uint cup_type;

	public uint cup_id;

	public uint team_tier;

	public CupGroupMemberInfo group_member_info;
}
