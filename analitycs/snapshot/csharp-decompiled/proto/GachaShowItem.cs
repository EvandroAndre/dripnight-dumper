using ProtoBuf;

namespace proto;

public class GachaShowItem : IMessage
{
	public uint item_id;

	public bool is_show;

	public EInventory.AwardType item_type;

	public uint item_num;

	public uint reward_level;

	public uint turntable_props_type;

	public float drop_up_ratio;

	public bool is_drop_up_buffed;

	public uint id;

	public uint item_duration;

	public bool token_flag;

	public ELottery.RareType rare_item;

	public bool is_remove;

	public uint round;

	public uint item_copy_count;

	public ESharedGacha.RareType shared_gacha_rare_item;

	public bool is_congrats;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
