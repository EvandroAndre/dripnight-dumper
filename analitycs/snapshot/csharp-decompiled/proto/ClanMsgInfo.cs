using System.Collections.Generic;

namespace proto;

public class ClanMsgInfo
{
	public ulong msg_id;

	public EClan.ClanMsgType msg_type;

	public ulong msg_trigger;

	public ClanMsgContents msg_contents;

	public List<ClanMsgReply> msg_replies;

	public long create_time;
}
