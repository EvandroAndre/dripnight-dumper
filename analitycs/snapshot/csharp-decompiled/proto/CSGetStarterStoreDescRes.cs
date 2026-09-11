using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetStarterStoreDescRes : IMessage
{
	public List<StarterStoreItemDesc> starter_store_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
