using ProtoBuf;

namespace proto;

public class TeamUpRecommendConfigDesc : IMessage
{
	public uint game_mode;

	public uint group_mode;

	public double kd;

	public double head_shot;

	public double win_rate;

	public uint invite_resp_check_threshold;

	public double invite_resp_refuse_rate;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
