using ProtoBuf;

namespace proto;

public class ChampionshipTeamDesc : IMessage
{
	public uint player_num_limit;

	public uint limit_num;

	public uint clean_time;

	public uint player_apply_num;

	public uint team_invite_num;

	public uint team_exit_cd;

	public uint team_join_cd;

	public uint team_scale_type;

	public uint player_num_min;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
