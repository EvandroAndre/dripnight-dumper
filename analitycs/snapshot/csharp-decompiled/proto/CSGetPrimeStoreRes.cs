using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetPrimeStoreRes : IMessage
{
	public PrimeStoreDesc prime_store_desc;

	public List<PrimeStoreItemDesc> prime_store_items;

	public List<PrimeStoreItemDesc> prime_gift_store_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
