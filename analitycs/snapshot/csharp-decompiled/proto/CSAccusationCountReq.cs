using System.Collections.Generic;

namespace proto;

public class CSAccusationCountReq
{
	public List<AccusationCount> accusation_counts;

	public string noti_region;

	public string lock_region;
}
