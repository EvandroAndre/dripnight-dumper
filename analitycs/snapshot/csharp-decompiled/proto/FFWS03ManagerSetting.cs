using System.Collections.Generic;

namespace proto;

public class FFWS03ManagerSetting
{
	public List<FFWSCharacterDesc> character_desc;

	public List<FFWSMatchRewardsDesc> match_rewards_desc;

	public List<FFWSTargetDesc> target_desc;

	public List<FFWSMatchDesc> match_desc;

	public FFWSTrainDesc train_desc;
}
