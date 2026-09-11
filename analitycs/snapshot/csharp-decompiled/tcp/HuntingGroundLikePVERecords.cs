using ProtoBuf;

namespace tcp;

public class HuntingGroundLikePVERecords : IMessage
{
	public uint difficulty;

	public uint max_round;

	public long fastest_time;

	public uint max_damage;

	public uint total_score;

	public uint highest_score;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
