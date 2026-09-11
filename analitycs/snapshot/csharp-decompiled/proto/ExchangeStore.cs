using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ExchangeStore : IMessage
{
	public ExchangeStoreDesc exchange_store_desc;

	public List<ExchangeStoreItemDesc> exchange_store_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
