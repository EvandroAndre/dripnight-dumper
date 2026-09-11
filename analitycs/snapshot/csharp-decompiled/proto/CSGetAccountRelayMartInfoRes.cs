using System.Collections.Generic;

namespace proto;

public class CSGetAccountRelayMartInfoRes
{
	public List<RelayMartDiscountCodeInfo> discount_code_infos;

	public uint[] purchased_goods_ids;

	public List<string> backup_codes_used;

	public List<RelayMartSharedDiscountCode> received_discount_codes;
}
