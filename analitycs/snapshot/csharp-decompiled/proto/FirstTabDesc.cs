using ProtoBuf;

namespace proto;

public class FirstTabDesc : IMessage
{
	public uint first_tab_id;

	public string first_tab_name;

	public uint priority;

	public bool is_hide;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
