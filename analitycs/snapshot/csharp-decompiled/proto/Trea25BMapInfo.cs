using System.Collections.Generic;

namespace proto;

public class Trea25BMapInfo
{
	public uint map_id;

	public uint mining_count;

	public uint grid_claimed_count;

	public List<Trea25BGridInfo> grids;

	public uint[] random_trea_pieces;
}
