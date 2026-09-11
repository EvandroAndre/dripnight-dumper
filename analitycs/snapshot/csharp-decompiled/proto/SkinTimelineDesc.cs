using ProtoBuf;

namespace proto;

public class SkinTimelineDesc : IMessage
{
	public uint id;

	public uint type;

	public string res_conf1;

	public string res_conf2;

	public string res_conf3;

	public long start_time;

	public long end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
