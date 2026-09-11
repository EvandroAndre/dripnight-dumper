using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetExchangeStoreRes : IMessage
{
	public List<ExchangeStore> exchangeStores;

	public List<RankExchangeDisplayDesc> display_desc;

	public List<RankExchangeLimitItemDesc> exchange_store_item_desc;

	public List<PVEExchangeStoreDesc> pve_exchange_store_desc;

	public List<ClanStoreCommodityConfigDesc> clan_exchange_store_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
