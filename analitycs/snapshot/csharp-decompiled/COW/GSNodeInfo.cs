using System.Collections.Generic;
using tcp;

namespace COW;

internal class GSNodeInfo
{
	public string IDC;

	public int Ping_Time;

	public List<string> IP_List;

	public string LockRegion;

	public bool IsProxy;

	public static implicit operator AccountIDCPingInfo(GSNodeInfo info)
	{
		return null;
	}
}
