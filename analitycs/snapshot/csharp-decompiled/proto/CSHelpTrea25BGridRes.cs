using System.Collections.Generic;

namespace proto;

public class CSHelpTrea25BGridRes
{
	public ulong target_account_id;

	public uint map_id;

	public int grid_index;

	public Trea25BErrorCode code;

	public uint goldenshovel_count;

	public Trea25BGridInfo grid_info;

	public List<Trea25BGridInfo> updated_grids;

	public uint target_be_helped_count;
}
