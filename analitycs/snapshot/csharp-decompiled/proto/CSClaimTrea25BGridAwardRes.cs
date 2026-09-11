using System.Collections.Generic;

namespace proto;

public class CSClaimTrea25BGridAwardRes
{
	public uint map_id;

	public List<Trea25BGridData> grid_datas;

	public List<Trea25BGridData> finished_grid_datas;

	public uint goldenshovel_count;

	public uint cur_progress;

	public Trea25BMapInfo new_map;
}
