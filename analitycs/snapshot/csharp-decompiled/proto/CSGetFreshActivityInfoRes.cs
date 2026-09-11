using System.Collections.Generic;

namespace proto;

public class CSGetFreshActivityInfoRes
{
	public uint day;

	public List<ActivityInfo> activitys;

	public ulong expire_time;
}
