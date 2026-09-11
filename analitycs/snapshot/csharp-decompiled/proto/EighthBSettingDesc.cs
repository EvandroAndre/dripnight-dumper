using System.Collections.Generic;

namespace proto;

public class EighthBSettingDesc
{
	public class LinkageTaskInfo
	{
		public uint cdt_type;

		public uint cdt_value;

		public uint token_cnt;

		public uint game_mode;
	}

	public uint token_id;

	public uint TokenConsume;

	public List<LinkageTaskInfo> linkage_task;

	public uint linkage_daily_limit;

	public uint draw_steps;

	public uint[] fillings_num;

	public uint random_pool_item;

	public uint ai_generate_times;

	public bool is_leader_default;

	public uint linkage_br_gopos;

	public string linkage_br_sub_gopos;

	public uint linkage_cs_gopos;

	public string linkage_cs_sub_gopos;

	public string train_cdn_url;
}
