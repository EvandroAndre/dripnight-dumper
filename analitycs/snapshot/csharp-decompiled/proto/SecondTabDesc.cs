using ProtoBuf;

namespace proto;

public class SecondTabDesc : IMessage
{
	public uint second_tab_id;

	public uint first_tab_id;

	public uint priority;

	public string icon;

	public int quantity_adjust;

	public bool is_hide;

	public bool is_need_filter;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
