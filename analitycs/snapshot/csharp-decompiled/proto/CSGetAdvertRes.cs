using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetAdvertRes : IMessage
{
	public List<AdvertDesc> advert_items;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
