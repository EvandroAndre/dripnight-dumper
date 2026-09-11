using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ActivityBingoRewardsDesc : IMessage
{
	public uint id;

	public uint level;

	public uint[] activity_ids;

	public List<AwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
