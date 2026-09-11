using System.Collections.Generic;

namespace proto;

public class CSGetAccountVipCardInfosRes
{
	public List<VipCardInfo> infos;

	public List<VipCardPurchaseInfo> purchase_infos;

	public long timezone_offset_secs;
}
