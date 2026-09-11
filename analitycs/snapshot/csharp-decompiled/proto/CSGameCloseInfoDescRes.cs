using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGameCloseInfoDescRes : IMessage
{
	public List<GameCloseInfoDesc> game_close_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
