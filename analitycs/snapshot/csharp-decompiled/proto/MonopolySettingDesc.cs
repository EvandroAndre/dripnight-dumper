using System.Collections.Generic;

namespace proto;

public class MonopolySettingDesc
{
	public uint max_node;

	public uint ticket_id;

	public uint token_id;

	public List<AwardDesc> awards;

	public uint forward_step;

	public uint backward_step;

	public uint buff_multiple;

	public uint buff_time;

	public uint token_num;

	public uint start_token_num;

	public uint phase1_num;

	public uint phase2_num;

	public uint phase3_num;
}
