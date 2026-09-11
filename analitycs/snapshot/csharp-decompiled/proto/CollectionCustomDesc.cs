using ProtoBuf;

namespace proto;

public class CollectionCustomDesc : IMessage
{
	public uint item_id;

	public uint bundle_id;

	public uint item_type;

	public uint[] custom_types;

	public string custom_title_key;

	public string popup_cdn;

	public string button_cdn1;

	public string info_vfx;

	public uint[] sort_ids;

	public uint color_id;

	public string prime_board_res_id;

	public uint[] default_sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
