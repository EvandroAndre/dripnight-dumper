using ProtoBuf;

namespace proto;

public class ExchangeCurrencyLocalUseDesc : IMessage
{
	public uint id;

	public string use;

	public uint use_go_pos;

	public string use_sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
