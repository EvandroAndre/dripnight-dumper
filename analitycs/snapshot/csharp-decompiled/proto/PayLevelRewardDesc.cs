using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PayLevelRewardDesc : IMessage
{
	public uint id;

	public uint level;

	public EStore.PayLevelRewardHintType hint;

	public List<AwardDesc> awards;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
