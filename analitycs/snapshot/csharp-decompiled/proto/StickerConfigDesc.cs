using ProtoBuf;

namespace proto;

public class StickerConfigDesc : IMessage
{
	public uint sticker_id;

	public uint type;

	public string name;

	public string icon;

	public string text;

	public uint[] is_default_show;

	public float[] default_show_pos;

	public uint limited_number;

	public uint group_id;

	public string preview_icon;

	public uint production_channel;

	public uint production_source_id;

	public uint go_pos;

	public string sub_go_pos;

	public long show_time;

	public long stop_show_time;

	public uint[] is_ban_operation_array;

	public string time_color;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
