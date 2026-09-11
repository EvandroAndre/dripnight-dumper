using System.Collections.Generic;

namespace proto;

public class CSGetJumpsuitInfoRes
{
	public float curr_amount;

	public float curr_storage;

	public long update_time;

	public uint next_reset_time;

	public uint[] rewarded_stages;

	public uint rewarded_box_num;

	public List<JumpsuitHelpInfo> helper_list;

	public ulong[] helped_list;
}
