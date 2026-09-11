using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class HuntingGroundLikePVEInfo : IMessage
{
	public uint game_mode;

	public uint[] unlocked_difficulties;

	public List<HuntingGroundLikePVERecords> records;

	public List<PVERewardHistory> reward_history;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
