using System.Collections.Generic;

namespace proto;

public class CSPayBundleWindowPurchaseRes
{
	public List<AwardDesc> awards;

	public uint purchase_times;

	public EStore.RebateCardBillStatus status;

	public uint id;
}
