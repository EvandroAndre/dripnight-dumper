using System.Collections.Generic;

namespace proto;

public class CSGetActivityRewardsReq
{
	public uint[] activity_ids;

	public string language;

	public GetExchangeRewardsInfo exchange_rewards_info;

	public ulong group_id;

	public List<ActivityMultiCdtValueInfo> multi_cdt_value_rewards;
}
