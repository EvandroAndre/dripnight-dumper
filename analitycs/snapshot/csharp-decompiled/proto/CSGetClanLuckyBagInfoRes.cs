using System.Collections.Generic;

namespace proto;

public class CSGetClanLuckyBagInfoRes
{
	public List<ClanLuckyBag> lucky_bags;

	public List<LuckyBagDraw> draws;

	public bool is_reach_max_draw_num;

	public uint batch_draw_lucky_bag_max_counts;
}
