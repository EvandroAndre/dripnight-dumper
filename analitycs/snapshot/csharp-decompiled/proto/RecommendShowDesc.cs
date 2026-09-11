using ProtoBuf;

namespace proto;

public class RecommendShowDesc : IMessage
{
	public uint high_kd;

	public uint high_win_rate;

	public uint high_head_shot;

	public uint high_streak;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
