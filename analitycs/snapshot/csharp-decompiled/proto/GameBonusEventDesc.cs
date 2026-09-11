using ProtoBuf;

namespace proto;

public class GameBonusEventDesc : IMessage
{
	public string region;

	public uint id;

	public uint match_mode;

	public uint game_mode;

	public uint map_id;

	public int group_mode;

	public uint exp_bonus;

	public uint gold_bonus;

	public uint gold_limit;

	public uint debris_limit;

	public string start_time;

	public string end_time;

	public long start_timestamp;

	public long end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
