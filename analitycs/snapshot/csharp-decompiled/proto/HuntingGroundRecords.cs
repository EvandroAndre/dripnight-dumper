using ProtoBuf;

namespace proto;

public class HuntingGroundRecords : IMessage
{
	public uint difficulty;

	public uint max_round;

	public long fastest_time;

	public uint max_damage;

	public uint period_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
