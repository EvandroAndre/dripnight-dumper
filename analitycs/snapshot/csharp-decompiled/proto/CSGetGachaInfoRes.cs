using System.Collections.Generic;

namespace proto;

public class CSGetGachaInfoRes
{
	public List<GachaInfo> gacha_info_list;

	public ELottery.LuckySpinType lucky_spin_type;

	public uint lucky_spin_unique_id;

	public uint lucky_spin_sub_id;

	public uint month_max_reward_count;

	public long month_max_reward_ts;
}
