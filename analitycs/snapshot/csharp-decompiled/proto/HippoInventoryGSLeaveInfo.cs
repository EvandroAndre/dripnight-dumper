using System.Collections.Generic;

namespace proto;

public class HippoInventoryGSLeaveInfo
{
	public uint enter_gs_version;

	public List<HippoInventoryEquipItem> equip_items;

	public int money_delta;
}
