using System.Collections.Generic;

namespace proto;

public class BooyahgoMiniGameSettingDesc
{
	public uint max_node;

	public uint ticket_id;

	public uint token_id;

	public List<AwardDesc> awards;

	public uint forward_step;

	public uint trapped_step;

	public uint buff_multiple;

	public uint buff_time;

	public uint token_num;

	public uint start_token_num;

	public uint skull_king_move_rounds;

	public uint skull_king_max_rounds;

	public uint points_per_step;

	public uint skull_king_left_pos;

	public uint skull_king_right_pos;

	public uint skull_king_move1_weight;

	public uint skull_king_move2_weight;

	public uint ranking_start_time;

	public uint ranking_end_time;

	public string phase1_story;

	public string phase2_story;

	public string phase3_story;

	public uint phase1_num;

	public uint phase2_num;

	public uint phase3_num;
}
