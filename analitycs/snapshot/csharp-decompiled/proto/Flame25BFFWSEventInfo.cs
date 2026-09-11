using System.Collections.Generic;

namespace proto;

public class Flame25BFFWSEventInfo
{
	public class EventInfo
	{
		public ulong event_serial_id;

		public string ffws_msg;

		public string ffws_extra;

		public uint period;

		public long begin_time;

		public long end_time;
	}

	public List<EventInfo> events;
}
