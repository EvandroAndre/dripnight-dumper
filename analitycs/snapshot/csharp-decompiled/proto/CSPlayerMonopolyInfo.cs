using System.Collections.Generic;

namespace proto;

public class CSPlayerMonopolyInfo
{
	public ulong account_id;

	public uint dice_number;

	public EMiniGame.MonopolyPlayerStatus player_status;

	public uint current_index;

	public uint total_cycles;

	public MonopolyBoard monopoly_board;

	public List<TriggeredEvent> events;

	public uint current_event;

	public uint current_activity;

	public uint buff_remain_time;
}
