using System.Collections.Generic;

namespace proto;

public class CSGetPony25BRedDotInfoRes
{
	public bool has_claimable_red_dot;

	public uint cur_progress;

	public List<Pony25BPOIBaseDesc> poi_bases;

	public List<Pony25BPOIExploreDesc> poi_explores;
}
