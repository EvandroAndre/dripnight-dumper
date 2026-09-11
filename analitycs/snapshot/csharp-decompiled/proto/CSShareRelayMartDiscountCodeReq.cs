using System.Collections.Generic;

namespace proto;

public class CSShareRelayMartDiscountCodeReq
{
	public uint relay_mart_id;

	public List<DiscountCodeShareSetting> shared_settings;
}
