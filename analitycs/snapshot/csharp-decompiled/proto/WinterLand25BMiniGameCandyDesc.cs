using System.Collections.Generic;

namespace proto;

public class WinterLand25BMiniGameCandyDesc
{
	public class CandyInfo
	{
		public uint candy_id;

		public uint total_num;

		public uint speed;

		public uint combo_num;
	}

	public uint stage_id;

	public uint stage_time;

	public List<CandyInfo> candy_list;
}
