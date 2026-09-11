using ProtoBuf;

namespace proto;

public class ClanInfoBasic : IMessage
{
	public ulong clan_id;

	public string clan_name;

	public ulong captain_id;

	public uint clan_level;

	public uint capacity;

	public uint member_num;

	public uint honor_point;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
