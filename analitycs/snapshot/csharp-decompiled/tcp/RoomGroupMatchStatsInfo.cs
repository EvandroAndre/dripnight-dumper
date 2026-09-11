using System.Collections.Generic;

namespace tcp;

public class RoomGroupMatchStatsInfo
{
	public ulong group_id;

	public uint rank;

	public uint score;

	public string name;

	public List<RoomPlayerMatchStatsInfo> member_match_stats_infos;

	public uint group_index;
}
