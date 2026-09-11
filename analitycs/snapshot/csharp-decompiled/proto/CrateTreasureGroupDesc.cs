using ProtoBuf;

namespace proto;

public class CrateTreasureGroupDesc : IMessage
{
	public uint group_id;

	public uint num_group;

	public bool is_repeatable;

	public string icon;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
