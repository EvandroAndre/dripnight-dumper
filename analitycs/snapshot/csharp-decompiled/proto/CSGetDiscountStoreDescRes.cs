using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetDiscountStoreDescRes : IMessage
{
	public List<DiscountStoreDesc> discountStores;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
