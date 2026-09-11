using System.Collections.Generic;

namespace proto;

public class HippoInventoryGSEnterInfo
{
	public enum DataFlag
	{
		None = 0,
		Success = 1,
		InGameServer = 2,
		BagFull = 4
	}

	public uint enter_gs_version;

	public List<HippoInventoryEquipItem> equip_items;

	public uint safe_box_level;

	public uint warehouse_level;

	public uint equip_slot_price;

	public uint total_price;

	public List<HippoInventoryVirtualParam> virtual_params;

	public uint data_flags;

	public uint in_gs_unlock_ts;
}
