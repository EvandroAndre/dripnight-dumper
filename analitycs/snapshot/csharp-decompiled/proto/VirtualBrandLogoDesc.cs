using ProtoBuf;

namespace proto;

public class VirtualBrandLogoDesc : IMessage
{
	public uint brand_id;

	public uint sort_id;

	public string brand_logo_id;

	public bool new_brand;

	public bool warm_up_brand;

	public string combine_desc;

	public string combine_vfx;

	public long pre_start_time_stamp;

	public long pre_end_time_stamp;

	public long start_time_stamp;

	public bool is_open;

	public string brand_name;

	public string brand_word_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
