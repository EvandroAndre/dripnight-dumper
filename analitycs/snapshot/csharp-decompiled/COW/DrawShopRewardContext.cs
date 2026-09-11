using System;
using System.Collections.Generic;

namespace COW;

public class DrawShopRewardContext
{
	public uint DrawShopId;

	public List<object> RewardList;

	public object ExtraReward;

	public bool EnableRepurchase;

	public Action OnCloseCallback;
}
