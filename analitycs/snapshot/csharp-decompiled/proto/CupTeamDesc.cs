using ProtoBuf;

namespace proto;

public class CupTeamDesc : IMessage
{
	public uint limit_num;

	public uint clean_time;

	public uint player_apply_num;

	public uint team_invite_num;

	public uint team_join_cd;

	public uint team_exit_cd;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
