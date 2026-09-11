using System.Collections.Generic;

namespace tcp;

public class HistoryMessageNtf
{
	public ChannelIDReq channel;

	public List<TextMsgReq> history_messages;
}
