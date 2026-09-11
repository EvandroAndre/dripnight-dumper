using ProtoBuf;

namespace proto;

public class OccupationProficiencyLevelDesc : IMessage
{
	public uint occupation_id;

	public uint level;

	public uint point;

	public uint rank;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
