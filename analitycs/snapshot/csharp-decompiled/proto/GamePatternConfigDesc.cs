using ProtoBuf;

namespace proto;

public class GamePatternConfigDesc : IMessage
{
	public uint game_pattern;

	public uint game_mode;

	public uint match_mode;

	public uint mmr_lower;

	public uint mmr_upper;

	public uint rank_lower;

	public uint rank_upper;

	public string game_pattern_title_icon;

	public string game_pattern_title_key;

	public uint level_lower;

	public uint level_upper;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
