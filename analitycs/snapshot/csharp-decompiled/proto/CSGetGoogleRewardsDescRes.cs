using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetGoogleRewardsDescRes : IMessage
{
	public List<GoogleRewardsDesc> reward_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
