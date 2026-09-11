using ProtoBuf;

namespace proto;

public class CupOpenInfoDesc : IMessage
{
	public uint cup_type;

	public uint cup_id;

	public long entrance_open_time;

	public long entrance_end_time;

	public long season_start_time;

	public long season_end_time;

	public long match_start_time;

	public long match_end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
