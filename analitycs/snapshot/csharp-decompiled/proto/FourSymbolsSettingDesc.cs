using System.Collections.Generic;

namespace proto;

public class FourSymbolsSettingDesc
{
	public bool assemble_switch;

	public bool store_switch;

	public bool sign_in_switch;

	public bool mission_switch;

	public bool mode_switch;

	public uint mode_show_time_start;

	public uint mode_time_start;

	public uint mode_time_end;

	public uint mode_go_pos;

	public uint mode_sub_go_pos;

	public string web_url;

	public uint web_event_start;

	public uint web_event_end;

	public uint token_id;

	public uint rev1_start;

	public uint rev1_end;

	public uint rev1_go_pos;

	public uint rev1_sub_go_pos;

	public string rev1_cdn;

	public string rev1_key;

	public uint rev2_start;

	public uint rev2_end;

	public uint rev2_go_pos;

	public uint rev2_sub_go_pos;

	public string rev2_cdn;

	public string rev2_key;

	public uint four_symbols_chat_duration;

	public List<AwardDesc> chess_final_awards;

	public List<AwardDesc> sign_in_accumulate_awards;

	public uint cumulative_times;

	public string final_node_title_key;

	public string final_node_text_key;

	public string web_cdn;
}
