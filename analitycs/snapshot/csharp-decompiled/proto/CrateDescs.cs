using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CrateDescs : IMessage
{
	public uint crate_id;

	public List<CrateTreasureGroupDesc> treasure_group;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
