using System.Collections.Generic;

namespace proto;

public class CSGetAccountTeamTopUpInfoRes
{
	public TopUpTeam team;

	public List<TopUpTeamInvitation> invitations;

	public uint[] claimed_award_tier_ids;

	public uint top_up_amount;

	public bool has_created_team;

	public uint created_team_count;

	public long last_create_team_timestamp;
}
