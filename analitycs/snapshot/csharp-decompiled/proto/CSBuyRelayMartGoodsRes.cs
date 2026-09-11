using System.Collections.Generic;

namespace proto;

public class CSBuyRelayMartGoodsRes
{
	public ExchangeChangeData awards;

	public uint[] purchased_goods_ids;

	public RelayMartDiscountCodeInfo discount_code_info;

	public List<string> backup_codes_used;
}
