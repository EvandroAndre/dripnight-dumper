using ProtoBuf;

namespace proto;

public class ExchangeCurrencyLocalDesc : IMessage
{
	public uint id;

	public string origin;

	public string start_time;

	public string end_time;

	public uint go_pos;

	public string sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
