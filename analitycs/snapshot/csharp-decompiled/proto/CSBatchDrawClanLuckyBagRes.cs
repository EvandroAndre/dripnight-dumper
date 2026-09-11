using System.Collections.Generic;

namespace proto;

public class CSBatchDrawClanLuckyBagRes
{
	public List<DrawClanLuckyBagResultInfo> result_infos;

	public bool is_reach_max_draw_num;

	public uint batch_draw_lucky_bag_max_counts;

	public bool is_reach_batch_draw_lucky_bag_max_counts;

	public List<DrawLuckBagResult> draw_result;
}
