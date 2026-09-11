using System.Collections.Generic;

namespace proto;

public class CSLuckyWheelInfo
{
	public uint wheel_id;

	public uint remain_free_refresh_times;

	public List<CSLuckyWheelDiscountInfo> discount_info_list;

	public uint[] current_shop_item_id_list;

	public List<CSLuckyWheelShopItemInfo> shop_item_info_list;
}
