using ProtoBuf;

namespace proto;

public class AccountInfoWithStats : IMessage
{
	public ulong account_id;

	public uint games_played;

	public uint wins;

	public uint kills;

	public string detailed_stats;

	public bool is_cs_ranking;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
