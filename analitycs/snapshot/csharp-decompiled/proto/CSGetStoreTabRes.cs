using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetStoreTabRes : IMessage
{
	public List<StoreTableDesc> store_tables;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
