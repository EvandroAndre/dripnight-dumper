using ProtoBuf;

namespace proto;

public class TeamingScoreRuleDesc : IMessage
{
	public uint match_mode;

	public uint game_mode;

	public uint group_mode;

	public uint team_limit_rank_low;

	public uint team_limit_rank_high;

	public uint team_limit_rank_rule;

	public uint discount;

	public uint season_start;

	public uint season_end;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
