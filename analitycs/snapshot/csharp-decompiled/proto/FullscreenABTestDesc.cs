using ProtoBuf;

namespace proto;

public class FullscreenABTestDesc : IMessage
{
	public string region;

	public uint account_id;

	public uint anim_id;

	public uint anim_type;

	public uint system_pos;

	public uint go_pos;

	public string fullscreen_resource_id_a;

	public string fullscreen_resource_id_b;

	public string skin_resource_list_a;

	public string skin_resource_list_b;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
