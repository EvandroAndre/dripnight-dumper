using System.Collections.Generic;

namespace proto;

public class CSGetHippoInventoryDescRes
{
	public List<HippoWarehouseLevelDesc> warehouse_levels;

	public List<HippoStoreDesc> stores;

	public uint default_bag_capacity;

	public uint default_safebox_capacity;

	public List<HippoValueLimitDesc> value_limit_list;

	public uint free_buy_allow_value;

	public uint free_buy_max_value;
}
