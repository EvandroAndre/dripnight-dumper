using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class HuntingGroundDetailedInfo : IMessage
{
	public uint unlocked_difficulty;

	public List<HuntingGroundRecords> records;

	public uint[] unlocked_difficulties;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
