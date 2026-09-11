using ProtoBuf;

namespace proto;

public class OccupationInfo : IMessage
{
	public uint occupation_id;

	public ulong scores;

	public ulong proficients;

	public uint proficient_lv;

	public bool is_select;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
