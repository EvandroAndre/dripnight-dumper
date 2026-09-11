using ProtoBuf;

namespace proto;

public class DailyQuestRewardsStatus : IMessage
{
	public uint process_id;

	public EPTarget_Status status;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
