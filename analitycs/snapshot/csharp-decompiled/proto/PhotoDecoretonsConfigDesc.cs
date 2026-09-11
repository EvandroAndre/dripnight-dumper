using ProtoBuf;

namespace proto;

public class PhotoDecoretonsConfigDesc : IMessage
{
	public uint id;

	public uint sort_id;

	public long show_time;

	public long stop_show_time;

	public string preview_icon;

	public string name;

	public uint[] ban_operation;

	public string resource_name;

	public float[] default_show_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
