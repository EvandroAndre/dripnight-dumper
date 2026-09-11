using System.Collections.Generic;

namespace proto;

public class CSHippoInventoryPurchasesReq
{
	public class PurchasesInfo
	{
		public uint store_id;

		public uint amount;
	}

	public List<PurchasesInfo> purchases_list;
}
