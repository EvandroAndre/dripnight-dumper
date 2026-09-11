using System.Collections.Generic;

namespace proto;

public class CSHippoInventorySellReq
{
	public class SellInfo
	{
		public ulong inst_id;

		public uint amount;

		public EHippoInventory.EquipType equip_type;
	}

	public List<SellInfo> sell_list;
}
