using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetStoreRes : IMessage
{
	public List<StoreDesc> store_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
