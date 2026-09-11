using System.Collections.Generic;

namespace proto;

public class CSGetActivityRewardsRes
{
	public AwardData awards;

	public List<ActivityUpdateInfo> update_activitys;

	public ExchangeChangeData exchange_awards;
}
