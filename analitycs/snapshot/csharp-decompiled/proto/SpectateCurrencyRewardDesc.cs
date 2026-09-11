using ProtoBuf;

namespace proto;

public class SpectateCurrencyRewardDesc : IMessage
{
	public uint id;

	public EStats.SpectateRewardType reward_type;

	public uint value;

	public uint discount;

	public uint recv_value;

	public uint show_left_coin;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
