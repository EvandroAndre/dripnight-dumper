using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class GroupInviteNtf : IMessage
{
	public ulong group_id;

	public GroupMemberInfo inviter_info;

	public uint[] map_ids;

	public uint game_mode;

	public uint group_mode;

	public uint match_mode;

	public string secret_code;

	public EGroup.InviteeType target_type;

	public uint difficulty;

	public List<string> topic_workshop_codes;

	public ulong social_match_id;

	public uint social_mode;

	public uint member_cnt;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
