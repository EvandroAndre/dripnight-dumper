namespace proto;

public class PBAccountDrawShopWheelInfo
{
	public ulong account_id;

	public uint shop_id;

	public uint pity_cnt;

	public uint[] shop_goods;

	public uint[] purchased_goods;

	public long free_purchase_time;

	public uint limit_dis_cnt_one;

	public uint limit_dis_cnt_multi;

	public uint daily_dis_cnt_one;

	public long daily_dis_one_time;

	public uint daily_dis_cnt_multi;

	public long daily_dis_multi_time;

	public DrawShopWheelExchangeInfo exchange_info;
}
