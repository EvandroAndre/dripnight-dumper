using System.Collections.Generic;

namespace proto;

public class CSGetVetBarrageInfoRes
{
	public uint main_group_id;

	public uint[] sub_group_ids;

	public uint[] barrage_types;

	public uint highlight_group;

	public List<VetBarrageInfo> infos;
}
