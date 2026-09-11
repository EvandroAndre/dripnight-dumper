using System.Collections.Generic;

namespace proto;

public class CSDrawShopPurchaseLimitedPoolItemRes
{
	public LimitedPoolInfo limited_pool_info;

	public List<ExchangedAward> exchanged_awards;

	public List<ItemTagInfo> tag_items;

	public uint selected_pool_item_id;
}
