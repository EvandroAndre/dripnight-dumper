using ProtoBuf;

namespace proto;

public class CSPeakPreTeamPointDesc : IMessage
{
	public uint pre_team_num;

	public uint[] players;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
