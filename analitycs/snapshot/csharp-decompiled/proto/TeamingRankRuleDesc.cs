using ProtoBuf;

namespace proto;

public class TeamingRankRuleDesc : IMessage
{
	public uint match_mode;

	public uint game_mode;

	public uint group_mode;

	public uint team_limit_rank_rule;

	public uint team_unlimited_num;

	public uint team_limit_rank_low;

	public uint team_limit_rank_high;

	public uint season_start;

	public uint season_end;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
