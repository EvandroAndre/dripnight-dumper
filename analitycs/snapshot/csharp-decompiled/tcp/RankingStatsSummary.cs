using ProtoBuf;

namespace tcp;

public class RankingStatsSummary : IMessage
{
	public uint game_mode;

	public uint group_mode;

	public float kd;

	public float head_short;

	public float win_rate;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
