using System.Collections.Generic;

namespace tcp;

public class GroupInviteReq
{
	public ulong invitee_id;

	public string invitee_region;

	public EGroup.InviteChannelType channel_type;

	public EGroup.InviteeType invitee_type;

	public string deeplink;

	public uint push_type;

	public uint difficulty;

	public List<string> topic_workshop_codes;

	public ulong social_match_id;

	public uint social_mode;
}
