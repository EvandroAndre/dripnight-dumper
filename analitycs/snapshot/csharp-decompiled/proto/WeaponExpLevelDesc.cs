using ProtoBuf;

namespace proto;

public class WeaponExpLevelDesc : IMessage
{
	public uint level;

	public uint downer_bound;

	public uint upper_bound;

	public uint cycle_level_diff;

	public bool is_v1_max_level;

	public uint addition;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
