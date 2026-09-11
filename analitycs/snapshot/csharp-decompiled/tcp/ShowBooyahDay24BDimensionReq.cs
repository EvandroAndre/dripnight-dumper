using System.Collections.Generic;

namespace tcp;

public class ShowBooyahDay24BDimensionReq
{
	public ulong group_id;

	public List<DimensionInfo> self_infos;

	public uint[] choose_dimension_ids;

	public string title;
}
