using ProtoBuf;

namespace proto;

public class HelperMessageDesc : IMessage
{
	public uint id;

	public uint[] game_mode;

	public uint trigger_event;

	public int[] condition1;

	public int[] sub_condition1;

	public int[] condition2;

	public int[] sub_condition2;

	public uint player_type;

	public uint weight;

	public string title;

	public string content;

	public string url;

	public uint go_pos;

	public string sub_go_pos;

	public string jump1;

	public string jump_key1;

	public string jump2;

	public string jump_key2;

	public string jump3;

	public string jump_key3;

	public long start_time;

	public long end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public bool GameModeMatch(uint mode)
	{
		return false;
	}

	public string GetModifyUrl()
	{
		return null;
	}
}
