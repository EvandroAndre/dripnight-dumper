using ProtoBuf;

namespace proto;

public class ReleaseVersion : IMessage
{
	public string name;

	public long start_time;

	public long end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
