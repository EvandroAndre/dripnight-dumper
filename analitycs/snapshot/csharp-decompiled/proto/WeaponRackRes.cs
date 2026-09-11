using ProtoBuf;

namespace proto;

public class WeaponRackRes : IMessage
{
	public uint[] weapon_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
