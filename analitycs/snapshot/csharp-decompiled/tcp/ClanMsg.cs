using System.Collections.Generic;

namespace tcp;

public class ClanMsg
{
	public ulong clan_id;

	public uint date;

	public ulong msg_id;

	public uint msg_type;

	public ulong msg_trigger;

	public ClanMsgContent content;

	public List<ClanMsgReply> replies;

	public long create_time;
}
