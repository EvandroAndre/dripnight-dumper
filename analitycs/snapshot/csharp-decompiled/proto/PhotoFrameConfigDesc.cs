using ProtoBuf;

namespace proto;

public class PhotoFrameConfigDesc : IMessage
{
	public uint item_id;

	public uint is_vertical;

	public uint sort_id;

	public long show_time;

	public long stop_show_time;

	public uint tag;

	public string preview_icon;

	public string logo_res;

	public string logo_des_res;

	public string preview_small_cdn_icon;

	public string preview_big_cdn_icon;

	public uint tip_group;

	public uint production_channel;

	public uint go_pos;

	public string sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
