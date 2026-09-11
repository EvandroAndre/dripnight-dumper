namespace proto;

public class DrawShopWheelGoodsDesc
{
	public uint draw_shop_id;

	public uint goods_id;

	public EInventory.AwardType reward_item_type;

	public uint item_id;

	public uint item_num;

	public uint item_duration;

	public bool rare_item;

	public bool is_remove;

	public uint drop_limit;

	public uint base_probability;

	public uint second_level_probability;

	public uint third_level_probability;

	public uint repeat_change_item_id;

	public uint repeat_change_item_num;

	public uint repeat_change_item_id_2;

	public uint repeat_change_item_num_2;
}
