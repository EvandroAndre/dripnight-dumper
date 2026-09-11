using System.Collections.Generic;

namespace COW;

public class BooyahPassRewardItemData
{
	public bool IsCircle;

	public bool HasBigReward;

	public BooyahPassRewardType RewardType;

	public uint RewardItemGrade;

	public string BigRewardCDN;

	public List<BooyahPassBaseItemData> BaseItemList;
}
