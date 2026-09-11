using System.Collections.Generic;

namespace proto;

public class BotAgentECADesc
{
	public uint id;

	public uint type;

	public uint priority;

	public uint source;

	public bool enable;

	public List<string> @params;

	public string action;

	public uint highlight_ui;

	public uint trigger_type;

	public string match_mode;

	public string game_mode;

	public string group_mode;

	public string show_to_special_player;

	public bool trigger_once;

	public bool trigger_in_battle;

	public uint trigger_above_memory_level;

	public string cd;
}
