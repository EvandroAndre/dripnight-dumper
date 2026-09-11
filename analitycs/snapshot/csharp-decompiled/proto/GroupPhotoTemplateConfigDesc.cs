using ProtoBuf;

namespace proto;

public class GroupPhotoTemplateConfigDesc : IMessage
{
	public uint id;

	public string desc;

	public uint go_pos;

	public string sub_go_pos;

	public long show_time;

	public long stop_show_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
