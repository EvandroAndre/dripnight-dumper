using ProtoBuf;

namespace proto;

public class AvatarProficiencyLevelDesc : IMessage
{
	public uint level;

	public uint exp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
