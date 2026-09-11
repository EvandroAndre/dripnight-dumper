using System.Collections.Generic;

namespace proto;

public class AdminDebugMatchmakingInfo
{
	public List<DebugAccountIDs> ingame_groups;

	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public uint match_mode;

	public uint difficulty;

	public bool is_hacker;

	public bool is_emulator;

	public List<AccountIDCPingInfo> ping_list;

	public string idc;

	public string gameserver_addr;

	public string secret;

	public DebugBotInfo debug_bot_info;

	public string udp_mask;

	public uint layer_id;

	public bool is_semi_warm;

	public List<DebugSemiAINums> semi_ai_nums;

	public uint semi_ai_level;

	public string gp_player_id;
}
