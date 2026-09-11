using System.Collections.Generic;

namespace proto;

public class CSDrawSharedGachaRes
{
	public List<ExchangedAward> gacha_goods;

	public uint[] unique_ids;

	public uint limit_purchase_count_one;

	public uint limit_purchase_count_ten;

	public uint limit_purchase_count_ten2;

	public uint limit_purchase_count_ten3;

	public uint rare_lucky_points;

	public List<ExchangeItemNum> exchange_item_num;

	public uint actual_money;

	public SharedGachaPoolInfo pool_info;

	public bool need_force_switch;

	public ESharedGacha.DrawStatus draw_status;

	public long free_draw_last_time;
}
