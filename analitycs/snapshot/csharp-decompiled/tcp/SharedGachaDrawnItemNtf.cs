using System.Collections.Generic;

namespace tcp;

public class SharedGachaDrawnItemNtf
{
	public ulong shared_gacha_id;

	public uint pool_version;

	public List<SharedGachaPoolItemInfo> pool_item_list;

	public List<SharedGachaHistoryInfo> drawn_items;

	public float pity_item_init_prob;

	public float pity_item_current_prob;
}
