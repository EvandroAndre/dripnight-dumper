using ProtoBuf;

namespace proto;

public class LoadoutInfo : IMessage
{
	public uint loadout_id;

	public uint loadout_num;

	public bool is_free_play;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
