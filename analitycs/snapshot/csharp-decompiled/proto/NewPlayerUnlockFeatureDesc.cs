using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class NewPlayerUnlockFeatureDesc : IMessage
{
	public string region;

	public uint game_mode;

	public uint match_mode;

	public uint affix_comb_id;

	public bool is_open;

	public uint event_id;

	public List<GamePatternAffix> game_pattern_affixes;

	public bool display_in_lobby;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
