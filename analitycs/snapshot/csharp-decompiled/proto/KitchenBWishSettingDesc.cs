using System.Collections.Generic;

namespace proto;

public class KitchenBWishSettingDesc
{
	public uint token_id;

	public uint cost_cnt;

	public uint single_wish_points;

	public uint double_wish_points;

	public uint triple_wish_points;

	public List<AwardDesc> extra_award;

	public string emoji_first_stage;

	public string emoji_second_stage;

	public string emoji_third_stage;

	public uint process_first_stage;

	public uint process_second_stage;

	public uint process_third_stage;
}
