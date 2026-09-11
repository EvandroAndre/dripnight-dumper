using System.Collections.Generic;

namespace proto;

public class CSGetItemLimitedInGameRes
{
	public class DropInfo
	{
		public uint item_id;

		public uint got_cnt;

		public uint daily_quantity;

		public uint game_mode;
	}

	public List<DropInfo> info;
}
