using ProtoBuf;

namespace proto;

public class MatchmakingTipsNewDesc : IMessage
{
	public uint tips_id;

	public uint game_mode;

	public uint match_mode;

	public uint tips_time;

	public string tips_key;

	public uint tips_rule_id;

	public string tips_rule_param1;

	public string tips_rule_param2;

	public string tips_rule_param3;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
