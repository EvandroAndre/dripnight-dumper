using System.Collections.Generic;

namespace proto;

public class ExchangeChangeData
{
	public ulong trans_id;

	public List<Item> add_item_list;

	public List<Item> del_item_list;

	public int coins_delta;

	public int gems_delta;

	public int gop_gems_delta;

	public EInventory.TransReason reason;

	public uint gop_gems;

	public ulong gop_total_topup;

	public ulong gop_total_free;

	public List<ExchangedAward> exchangeAward;

	public bool check_bundle;

	public ulong sub_reason;

	public List<HippoInventoryItem> hippo_add_items;

	public uint hippo_add_money;

	public uint gems_cost;

	public bool use_bundle_expire_time;
}
