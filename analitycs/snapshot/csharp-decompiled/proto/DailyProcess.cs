using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class DailyProcess : IMessage
{
	public uint challenge_num;

	public List<DailyProcessStatus> daily_process_status;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
