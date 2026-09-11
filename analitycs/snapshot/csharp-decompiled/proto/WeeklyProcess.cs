using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class WeeklyProcess : IMessage
{
	public uint week_id;

	public uint challenge_num;

	public List<WeeklyProcessStatus> weekly_process_status;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
