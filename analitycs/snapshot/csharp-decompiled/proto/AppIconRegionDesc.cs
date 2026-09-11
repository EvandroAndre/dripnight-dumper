using ProtoBuf;

namespace proto;

public class AppIconRegionDesc : IMessage
{
	public uint id;

	public string icon;

	public string desc;

	public uint type;

	public long start_time;

	public long end_time;

	public string region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
