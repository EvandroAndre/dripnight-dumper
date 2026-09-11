using System.Collections.Generic;

namespace proto;

public class LimitedPoolInfo
{
	public uint draw_shop_id;

	public uint draw_count;

	public uint current_price;

	public List<LimitedPoolItemInfo> pool_items;

	public uint[] pending_pool_item_ids;
}
