using System.Collections.Generic;

namespace proto;

public class CSHippoInventoryRepairReq
{
	public class RepairInfo
	{
		public ulong inst_id;

		public uint cost_money;

		public EHippoInventory.EquipType equip_type;
	}

	public List<RepairInfo> repair_list;

	public ulong group_id;

	public ulong room_id;
}
