using ProtoBuf;

namespace tcp;

public class AccountMatchVeteranData : IMessage
{
	public uint player_proficiency_type;

	public uint leave_days_tag;

	public uint leave_level;

	public uint force_bot_total;

	public uint social_match_left;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
