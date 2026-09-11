using System.Collections.Generic;

namespace proto;

public class CSGetMysteryPoolInfoRes
{
	public ulong account_id;

	public List<MysteryPoolStoreItem> normal_reward_list;

	public MysteryPoolStoreItem super_reward;

	public List<ClientMysteryShopSwitchDesc> pool_desc_list;
}
