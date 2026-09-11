using System.Collections.Generic;

namespace proto;

public class Chaos24BInfo
{
	public class PlayEventInfo
	{
		public uint period;

		public uint play_event_id;

		public uint consume_num;
	}

	public List<PlayEventInfo> infos;
}
