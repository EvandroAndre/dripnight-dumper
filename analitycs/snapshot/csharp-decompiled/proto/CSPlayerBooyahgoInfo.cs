using System.Collections.Generic;

namespace proto;

public class CSPlayerBooyahgoInfo
{
	public ulong account_id;

	public uint dice_number;

	public uint current_index;

	public uint total_cycles;

	public BooyahgoBoard booyahgo_board;

	public List<BooyahgoTriggeredEvent> events;

	public uint current_activity;

	public uint buff_remain_time;

	public bool under_trap;

	public uint points;

	public uint dice_count;
}
