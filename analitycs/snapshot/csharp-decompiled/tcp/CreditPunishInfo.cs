using ProtoBuf;

namespace tcp;

public class CreditPunishInfo : IMessage
{
	public uint cdt_type;

	public uint match_mode;

	public uint game_mode;

	public uint group_mode;

	public uint cdt_credit_score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
