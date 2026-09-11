using ProtoBuf;

namespace proto;

public class ExchangeCurrencyDesc : IMessage
{
	public uint id;

	public uint type;

	public uint subtype;

	public string website;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
