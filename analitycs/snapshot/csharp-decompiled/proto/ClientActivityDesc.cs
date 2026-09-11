using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class ClientActivityDesc : IMessage
{
	public uint group_id;

	public uint activity_id;

	public string act_title;

	public string act_text;

	public string award_context;

	public string image_url;

	public string image_url_for_lobby;

	public uint activity_type;

	public uint sort_id;

	public uint is_process_show;

	public uint act_tag;

	public uint gos_pos;

	public long start_time;

	public long end_time;

	public uint cdt_value;

	public List<AwardDesc> awards;

	public List<Item> exchange_items;

	public long show_time;

	public uint table_type;

	public string original_start_time;

	public string original_end_time;

	public string image_url_for_top_up;

	public uint affiliate_table;

	public uint activity_class;

	public long[] hint_reset_time;

	public uint pre_cdt_gos_pos;

	public uint[] pre_cdt_item_ids;

	public uint min_level;

	public uint max_level;

	public bool big_prize;

	public EActivity.SubType sub_type;

	public long stop_show_time;

	public EActivity.CircleType circle_type;

	public uint award_expression;

	public EActivity.ConditionType cdt;

	public EActivity.PreConditionType pre_cdt1;

	public uint pre_cdv1;

	public string sub_gos_pos;

	public uint row_id;

	public uint act_style;

	public uint top_fixed_pix;

	public uint row_pix;

	public List<ActivityRowDesc> row_infos;

	public uint recharge_show;

	public EActivity.PreConditionType pre_cdt2;

	public uint pre_cdv2;

	public bool is_stay_after_finished;

	public bool is_hide_goto;

	public long show_end_time;

	public bool is_hide_end_time;

	public uint show_end_time_style;

	public long real_end_time;

	public uint red_dot_refresh_interval;

	public EActivity.MultiCdtValuesType multi_cdt_values_type;

	public uint[] multi_cdt_values;

	public List<AwardDescList> multi_cdt_awards;

	public bool multi_claim;

	public uint max_data;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
