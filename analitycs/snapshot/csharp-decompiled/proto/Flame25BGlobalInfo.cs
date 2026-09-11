using System.Collections.Generic;

namespace proto;

public class Flame25BGlobalInfo
{
	public class Flame25BGlobalEvent
	{
		public ulong event_serial_id;

		public uint event_id;

		public uint event_type;

		public long event_time;

		public uint event_value;

		public ulong account_id;

		public uint like_count;
	}

	public List<Flame25BGlobalEvent> globals;
}
