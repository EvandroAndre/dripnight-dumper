using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetMatchmakingTipsNewDescRes : IMessage
{
	public List<MatchmakingTipsNewDesc> matchmaking_tips_new_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
