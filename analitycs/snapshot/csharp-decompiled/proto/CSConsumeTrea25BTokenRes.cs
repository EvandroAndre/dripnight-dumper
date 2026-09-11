using System.Collections.Generic;

namespace proto;

public class CSConsumeTrea25BTokenRes
{
	public uint cur_progress;

	public uint map_id;

	public Trea25BGridData grid_data;

	public List<Trea25BGridData> finished_grid_data;

	public uint goldenshovel_count;

	public Trea25BMapInfo new_map;

	public Trea25BErrorCode error_code;
}
