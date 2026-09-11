using ProtoBuf;

namespace proto;

public class ChestMultiPrice : IMessage
{
	public uint ten_num;

	public uint ten_price;

	public uint limit_num_ten;

	public uint[] limit_price_ten;

	public uint exchange_ten_num;

	public uint exchange_ten_num2;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
