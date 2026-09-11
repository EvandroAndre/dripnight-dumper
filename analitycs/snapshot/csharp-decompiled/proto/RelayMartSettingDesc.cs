using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RelayMartSettingDesc : IMessage
{
	public uint relay_mart_id;

	public long start_time_stamp;

	public long end_time_stamp;

	public uint first_discount;

	public uint second_discount;

	public uint final_discount;

	public string special_bg_cdn;

	public string special_coupon_cdn;

	public List<string> back_up_codes;

	public uint discount_number;

	public uint diamond_return_ratio;

	public string diamond_return_role_resource;

	public uint discount_lock_time;

	public string special_title_cdn;

	public string lobby_ui_fx;

	public uint friend_share_max_num;

	public uint friend_public_max_num;

	public uint other_public_max_num;

	public List<string> language;

	public bool if_pop_up_show;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
