using System.Collections.Generic;

namespace proto;

public class CustomTCCritRateDesc
{
	public class CritRateInfo
	{
		public uint multiple;

		public uint begin;

		public uint end;
	}

	public uint custom_event_id;

	public uint active_level;

	public uint no_crit_rate;

	public uint crit_rate_total;

	public List<CritRateInfo> crit_rates;

	public uint piece;
}
