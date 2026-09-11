using ProtoBuf;

namespace proto;

public class PhotoFilterSettingDesc : IMessage
{
	public uint id;

	public uint sort_id;

	public string filter_name;

	public uint filter_id;

	public string filter_cdn;

	public uint type;

	public uint is_vertical_uifx;

	public string uifx_resource;

	public uint is_lobby_2d_uifx;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
