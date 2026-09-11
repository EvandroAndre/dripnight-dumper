using System.Collections.Generic;

namespace proto;

public class PayBundleWindowDesc
{
	public uint id;

	public uint index_id;

	public uint price_item_id;

	public float price;

	public uint discount_price_rebate_id;

	public uint discount_price_item_id;

	public float discount_price;

	public uint rebate_percentage;

	public uint limited_purchase;

	public uint purchase_times;

	public List<AwardDesc> awards;

	public EStore.RebateCardBillStatus status;

	public uint diamond_price;

	public uint diamond_discount_price;

	public uint start_timestamp;

	public uint end_timestamp;

	public uint tag;

	public string bundle_name;

	public string cdn;

	public uint rebate_card_end_timestamp;

	public EStore.PbwActivityType activity_type;
}
