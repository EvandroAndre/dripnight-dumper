using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class TreasureBoxShow : IMessage
{
	public uint id;

	public List<TreasureBoxShowData> treasure_boxes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
