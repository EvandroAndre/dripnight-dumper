using System.Collections.Generic;
using proto;

namespace COW;

public class ClanTrendMsgInfo
{
	public ulong MsgID;

	public EClan.ClanMsgType MsgType;

	public ulong MsgTriggerID;

	public ulong MsgContentsAccountId;

	public uint MsgContentsReason;

	public Dictionary<uint, ClanTrendMsgEmoteReplyInfo> MsgEmojiReplyInfoDict;

	public long MsgCreatTime;

	public bool PlayerHaveReact;

	public bool ShowThisMsg;

	public ClanTrendMsgInfo(ClanMsgInfo data)
	{
	}

	public void RefreshMemberInfo()
	{
	}

	public void AddNewPlayerReply(uint emoji, ulong accountId)
	{
	}
}
