using System.Collections.Generic;

namespace proto;

public class CSEPClaimRewardReq
{
	public List<unlock> unlock_reward;

	public string nickname;

	public bool claim_max_reward;
}
