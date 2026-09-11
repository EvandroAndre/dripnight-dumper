using ProtoBuf;

namespace proto;

public class IPTagConfigDesc : IMessage
{
	public uint item_id;

	public string ip_tag_icon;

	public bool is_hide;

	public string region;

	public uint ip_privilege_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
