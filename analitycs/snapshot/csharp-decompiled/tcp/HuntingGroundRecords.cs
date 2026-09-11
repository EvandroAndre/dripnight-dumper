using ProtoBuf;

namespace tcp;

public class HuntingGroundRecords : IMessage
{
	public uint difficulty;

	public uint max_round;

	public long fastest_time;

	public uint max_damage;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
