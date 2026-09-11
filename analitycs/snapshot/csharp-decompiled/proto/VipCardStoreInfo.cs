using System.Collections.Generic;

namespace proto;

public class VipCardStoreInfo
{
	public uint id;

	public uint pos;

	public EVipCard.GoodsType type;

	public EVipCard.GoodsPriceType price_type;

	public uint price;

	public uint discount_price;

	public uint discount;

	public uint purchase_limit;

	public List<AwardDesc> awards;

	public uint purchase_time;
}
