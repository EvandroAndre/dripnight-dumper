using ProtoBuf;

namespace proto;

public class MapProtectionDesc : IMessage
{
	public long start_time;

	public long end_time;

	public uint match_mode;

	public uint map_id;

	public uint match_count;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
