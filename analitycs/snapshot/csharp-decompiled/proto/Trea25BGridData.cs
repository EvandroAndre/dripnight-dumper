using System.Collections.Generic;

namespace proto;

public class Trea25BGridData
{
	public int grid_index;

	public Trea25BGridInfo.EGridState temp_state;

	public Trea25BGridInfo grid_info;

	public List<Trea25BGridData> next_grids;
}
