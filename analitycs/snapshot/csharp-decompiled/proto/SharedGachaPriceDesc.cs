using System.Collections.Generic;

namespace proto;

public class SharedGachaPriceDesc
{
	public uint chest_id;

	public uint chest_sub_id;

	public uint once_price;

	public uint[] exchange_item_id;

	public uint[] exchange_item_id2;

	public List<ChestMultiPrice> multi_price_list;

	public uint exchange_once_num;

	public uint exchange_once_num2;
}
