using System.Collections.Generic;

namespace proto;

public class CSSetOccupationSelectReq
{
	public class SelectInfo
	{
		public uint game_mode;

		public uint match_mode;

		public uint occupation_id;

		public uint extend_val;
	}

	public ulong group_id;

	public ulong room_id;

	public List<SelectInfo> select_list;
}
