using ProtoBuf;

namespace proto;

public class HuntingGroundLikePVERecords : IMessage
{
	public uint difficulty;

	public uint max_round;

	public long fastest_time;

	public uint max_damage;

	public uint period_id;

	public uint highest_score;

	public uint total_score;

	public uint last_period_id;

	public uint period_max_round;

	public long period_fastest_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
