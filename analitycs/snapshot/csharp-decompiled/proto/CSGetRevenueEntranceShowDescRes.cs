using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetRevenueEntranceShowDescRes : IMessage
{
	public List<RevenueEntranceShowDesc> revenue_entrance_show_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
