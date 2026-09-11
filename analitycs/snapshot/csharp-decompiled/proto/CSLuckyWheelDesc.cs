using System.Collections.Generic;

namespace proto;

public class CSLuckyWheelDesc
{
	public uint wheel_id;

	public long start_time_stamp;

	public long end_time_stamp;

	public uint total_free_refresh_times;

	public uint refresh_currency_amount;

	public bool is_show_weight;

	public List<CSLuckyWheelDiscountDesc> discount_desc_list;

	public List<CSLuckyWheelShopItemDesc> shop_item_desc_list;
}
