using ProtoBuf;

namespace proto;

public class GameplayAffixDesc : IMessage
{
	public uint game_mode;

	public uint hint_key_id;

	public long start_time;

	public long end_time;

	public bool is_open;

	public uint[] match_mode;

	public uint[] affix_id;

	public uint event_open_id;

	public uint[] affix_comb_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
