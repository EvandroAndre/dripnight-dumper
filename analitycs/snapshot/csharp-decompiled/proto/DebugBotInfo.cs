using System.Collections.Generic;

namespace proto;

public class DebugBotInfo
{
	public uint bot_cnt;

	public uint bot_cnt_lv1;

	public uint bot_cnt_lv2;

	public uint bot_cnt_lv3;

	public uint bot_cnt_lv4;

	public uint bot_cnt_lv5;

	public uint bot_cnt_lv6;

	public uint ai_cnt;

	public List<AIInfo> ai_infos;

	public uint team_ai_cnt;

	public List<AIInfo> team_ai_infos;

	public uint teammate_ai_lv;

	public uint enemy_ai_lv;

	public uint ai_screen_play;

	public EGameServer.AIType ai_type;
}
