using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SharedGachaSettingDesc : IMessage
{
	public uint chest_id;

	public uint chest_sub_id;

	public uint show_type;

	public uint chest_model_id;

	public List<ESharedGacha.RareType> rare_item_type;

	public uint free_cd;

	public bool is_tab_vfx;

	public uint max_cap;

	public uint min_s;

	public uint min_a;

	public uint[] req_item;

	public uint[] req_item_num;

	public bool first_switch;

	public uint free_switch_cd;

	public uint switch_min_s;

	public uint switch_min_a;

	public uint[] switch_req_item;

	public uint[] switch_req_item_num;

	public uint hist_bullet_max;

	public string s_tier_cdn;

	public uint bubble_ratio_good;

	public uint bubble_ratio_bad;

	public double low_num_percentage;

	public List<ESharedGacha.RareType> low_num_tier;

	public string background_vfx;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
