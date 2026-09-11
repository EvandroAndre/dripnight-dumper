using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class VirtualBrandCollectionReward : IMessage
{
	public uint brand_id;

	public List<VirtualBrandCollectionValueRewardDesc> collection_rewards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
