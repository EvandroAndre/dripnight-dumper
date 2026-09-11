using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetShoppingMallScreenRes : IMessage
{
	public List<ShoppingMallScreenDesc> shopping_mall_screens;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
