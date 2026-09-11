using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class EPDailyProcessRewardDesc : IMessage
{
	public uint ep_event_id;

	public uint node_id;

	public uint challenge_num;

	public List<AwardDesc> awards;

	public string award_end_time;

	public long award_end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
