using System.Collections.Generic;
using proto;

namespace COW;

public class ClientActivityTipsDesc
{
	public uint ActivityId;

	public uint OrderId;

	public List<ActivityTipsDesc> TipsDescList;

	public ClientActivityTipsDesc(uint activityId, uint orderId)
	{
	}

	public void AddTipsDesc(ActivityTipsDesc desc)
	{
	}

	public ActivityTipsDesc GetTipsDesc(ActivityTipsShowType showType)
	{
		return null;
	}
}
