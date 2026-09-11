using System.Collections.Generic;

namespace proto;

public class WorkshopCreatorStats
{
	public ulong account_id;

	public uint follower_count;

	public uint exp;

	public List<CreatorLevelInfo> level_infos;

	public uint[] awarded_level;

	public string bio;

	public List<string> pinned_maps;

	public long latest_update_at;

	public uint map_count;
}
