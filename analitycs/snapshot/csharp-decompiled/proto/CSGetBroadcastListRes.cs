using System.Collections.Generic;

namespace proto;

public class CSGetBroadcastListRes
{
	public List<BroadcastMessage> broadcast_messages;

	public bool silence_show_switch;
}
