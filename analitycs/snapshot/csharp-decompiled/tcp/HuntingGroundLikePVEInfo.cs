using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class HuntingGroundLikePVEInfo : IMessage
{
	public uint game_mode;

	public uint[] unlocked_difficulties;

	public List<HuntingGroundLikePVERecords> records;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
