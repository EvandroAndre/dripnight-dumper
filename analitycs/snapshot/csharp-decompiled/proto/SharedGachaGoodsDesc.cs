namespace proto;

public class SharedGachaGoodsDesc
{
	public uint jackpot;

	public uint unique_id;

	public EInventory.AwardType item_type;

	public uint item_id;

	public string item_name;

	public uint item_num;

	public uint item_copy_count;

	public uint item_duration;

	public ESharedGacha.RareType rare_item;

	public uint owned_change_item_type;

	public uint owned_change_item_id;

	public uint owned_change_item_num;

	public bool is_congrats;
}
