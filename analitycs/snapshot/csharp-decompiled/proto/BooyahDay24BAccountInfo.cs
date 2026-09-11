using System.Collections.Generic;

namespace proto;

public class BooyahDay24BAccountInfo
{
	public List<BooyahDay24BDimensionInfo> self_infos;

	public List<BooyahDay24BDimensionInfo> useable_infos;

	public uint[] dimension_choose_ids;

	public uint br_max_star;

	public uint br_cur_star;

	public uint cs_max_star;

	public uint cs_cur_star;

	public bool br_star_claimed;

	public bool cs_star_claimed;

	public string title;

	public bool is_title_actived;
}
