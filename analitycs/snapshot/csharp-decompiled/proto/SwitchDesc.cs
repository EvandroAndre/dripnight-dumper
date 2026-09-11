using ProtoBuf;

namespace proto;

public class SwitchDesc : IMessage
{
	public ESwitch.SwitchFunc id;

	public bool is_open;

	public string content;

	public long open_start_time;

	public long open_end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
