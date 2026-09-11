using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class HippoInventoryGSEnterInfo : IMessage
{
	public uint enter_gs_version;

	public List<HippoInventoryEquipItem> equip_items;

	public uint safe_box_level;

	public uint warehouse_level;

	public uint equip_slot_price;

	public uint total_price;

	public List<HippoInventoryVirtualParam> virtual_params;

	public uint data_flags;

	public uint in_gs_unlock_ts;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
