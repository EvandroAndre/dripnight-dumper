using ProtoBuf;

namespace proto;

public class SpectateCurrencySettingDesc : IMessage
{
	public uint limit_per_match_per_player;

	public uint limit_per_day;

	public uint limit_recv_per_day;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
