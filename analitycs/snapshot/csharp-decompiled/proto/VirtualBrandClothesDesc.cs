using ProtoBuf;

namespace proto;

public class VirtualBrandClothesDesc : IMessage
{
	public uint brand_id;

	public uint vb_set_id;

	public uint sort_id;

	public string clothes_pic;

	public uint collection_value;

	public bool is_new;

	public long pre_start_time_stamp;

	public long pre_end_time_stamp;

	public uint bundle_id;

	public uint tab_type;

	public string clothes_warm_pic;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
