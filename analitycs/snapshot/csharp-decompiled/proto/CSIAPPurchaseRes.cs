using System.Collections.Generic;

namespace proto;

public class CSIAPPurchaseRes
{
	public List<AwardDesc> awards;

	public EStore.RebateCardBillStatus status;

	public ExchangeChangeData exchange_awards;

	public uint store_id;
}
