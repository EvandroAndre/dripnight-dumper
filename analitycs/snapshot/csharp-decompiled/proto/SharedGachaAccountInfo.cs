using System.Collections.Generic;

namespace proto;

public class SharedGachaAccountInfo
{
	public uint chest_id;

	public uint chest_sub_id;

	public ulong shared_gacha_id;

	public uint rare_lucky_points;

	public uint total_draw_count;

	public uint switch_total;

	public long switch_last_time;

	public long free_draw_last_time;

	public uint discount_count_single;

	public long last_update_time;

	public uint discount_count_batch1;

	public uint discount_count_batch2;

	public uint discount_count_batch3;

	public List<SharedGachaAccountRewardInfo> reward_list;
}
