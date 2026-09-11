using GCommon;
using ProtoBuf;

namespace proto;

public class BundleShowData : CSVBaseData, IMessage
{
	public uint ID;

	public uint award_id;

	public bool is_preview;

	public uint preview_avatar;

	public uint award_num;

	public EInventory.AwardType award_type;

	public string image_url;

	public EInventory.AwardType return_type;

	public uint return_id;

	public uint return_num;

	public string back_ground_url;

	public uint default_male_role;

	public uint default_female_role;

	public uint award_time;

	public uint no_forced_open;

	public uint award_unique_id;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static BundleShowData DeserializeOptimizedData(uint[] data, int offset)
	{
		return null;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void ParseFrom(ProtoReader reader)
	{
	}
}
