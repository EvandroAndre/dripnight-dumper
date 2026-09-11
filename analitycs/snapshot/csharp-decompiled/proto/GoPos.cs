using ProtoBuf;

namespace proto;

public class GoPos : IMessage
{
	public uint id;

	public string go_pos;

	public string sub_pos;

	public string go_pos2;

	public string sub_pos2;

	public uint start_time_stamp;

	public uint end_time_stamp;

	public uint type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
