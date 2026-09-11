using System.Collections.Generic;

namespace proto;

public class Carni25BActiveList
{
	public class TimeInfo
	{
		public long update_time;
	}

	public class ActiveInfo
	{
		public ulong account_id;

		public long update_time;
	}

	public List<ActiveInfo> infos;
}
