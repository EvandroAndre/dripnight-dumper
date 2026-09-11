using System.Collections.Generic;

namespace proto;

public class SharedGachaPoolInfo
{
	public ulong shared_gacha_id;

	public uint chest_id;

	public uint chest_sub_id;

	public uint pool_version;

	public List<SharedGachaPoolItemInfo> pool_item_list;

	public uint account_count;

	public uint online_count;

	public float pity_item_init_prob;

	public float pity_item_current_prob;
}
