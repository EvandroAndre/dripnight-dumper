using System.Collections.Generic;

namespace proto;

public class CSGetHippoInventoryAccountInfoRes
{
	public List<HippoInventoryEquipItem> items;

	public List<HippoInventoryStorePurchase> store_purchases;

	public uint money;

	public uint safe_box_level;

	public uint warehouse_level;

	public uint bag_weight;

	public uint safe_box_weight;

	public uint warehouse_weight;

	public List<HippoInventoryVirtualParam> virtual_params;
}
