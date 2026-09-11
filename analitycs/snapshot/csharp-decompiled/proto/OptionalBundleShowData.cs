using ProtoBuf;

namespace proto;

public class OptionalBundleShowData : IMessage
{
	public uint option_order;

	public EInventory.AwardType award_type;

	public uint award_id;

	public uint award_num;

	public uint award_time;

	public EInventory.AwardType return_type;

	public uint return_id;

	public uint return_num;

	public bool is_preview;

	public uint preview_avatar;

	public uint default_male_role;

	public uint default_female_role;

	public uint original_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
