using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetMysteryExpressionRes : IMessage
{
	public List<MysteryShopExpressionDesc> mystery_shop_expressions;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
