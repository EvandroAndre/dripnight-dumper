using System.Collections.Generic;

namespace tcp;

public class EPChallengesUpdateNtf
{
	public ulong account_id;

	public uint ep_id;

	public List<EPChallengesUpdateInfo> update_info;

	public EPChallengeIDsCompletedInfo completed_info;

	public List<RankingTaskUpdateInfo> br_update_info;

	public List<RankingTaskUpdateInfo> cs_update_info;
}
