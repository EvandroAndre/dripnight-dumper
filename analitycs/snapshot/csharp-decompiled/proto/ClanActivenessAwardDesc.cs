using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ClanActivenessAwardDesc : IMessage
{
	public EClan.ActivenessType activeness_type;

	public uint clan_level;

	public uint activeness_level;

	public uint activeness_value;

	public List<AwardDesc> awards;

	public uint activeness_limit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
