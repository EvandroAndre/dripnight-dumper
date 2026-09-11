using ProtoBuf;

namespace proto;

public class RankingActivityConfig : IMessage
{
	public string region;

	public string start_time;

	public string end_time;

	public ERanking.ActivityType activity_type;

	public uint start_timestamp;

	public uint end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
