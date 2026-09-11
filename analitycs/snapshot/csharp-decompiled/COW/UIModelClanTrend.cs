using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelClanTrend : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MessageInfo> _003C_003E9__28_0;

		public static Comparison<ClanTrendMsgInfo> _003C_003E9__37_0;

		internal int _003CRefreshMessageList_003Eb__28_0(MessageInfo a, MessageInfo b)
		{
			return 0;
		}

		internal int _003CInitClanMsgReplyInfoShowState_003Eb__37_0(ClanTrendMsgInfo a, ClanTrendMsgInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public ulong senderId;

		public ulong id;

		public EChannel.ChannelType type;

		internal bool _003CRemoveQuickAddFriendMessageInfo_003Eb__0(MessageInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UIModelClanTrend _003C_003E4__this;

		public ulong clanMsgId;

		public uint emojiId;

		internal void _003CRequestAddNewReactToTrendMessgae_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private List<ClanHighLightInfo> m_ClanHighLightInfo;

	private List<ClanTrendMsgInfo> m_ClanTrendMsgInfo;

	private List<MessageInfo> m_ClanMessageInfoList;

	private const uint REQUESTTRENDINFOTIMEDETAL = 180u;

	private ulong m_LastRequestTrendInfoTimeStamp;

	private uint m_ReplyErrorReqTrendTimes;

	private const uint MAX_REQTRENDINFOBYREPLYERRORTIMES = 10u;

	private const uint REPLYMSGPROTODETALTIME = 5u;

	private const uint MODIFYANNOUNCEMENTDETAL = 60u;

	private ulong m_LastReplyInfoReqTimeStamp;

	private ulong m_LastLikeHLMemberTimeStamp;

	public const string LASTOPENCLANPAGESHOWTIMESTAMP = "LASTOPENCLANPAGESHOWTIMESTAMP_";

	public const string LOBBY_CLAN_NOTICE_REFRESH = "LOBBY_CLAN_NOTICE_REFRESH_{0}";

	public const uint CS_RANK_MODE_TYPE = 6u;

	private ulong m_LastModifyAnnounceDateTime;

	private Dictionary<ulong, ClanTrendMsgInfo> m_ClanMsgReplyDict;

	public const uint PropID_ClanTendInfoRefresh = 2u;

	public const uint PropID_ClanTrendMemberTrendReplyRefresh = 4u;

	public const uint PropID_ClanTrendHLMemberLikeRefresh = 8u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<ClanHighLightInfo> GetClanHLMemberInfos()
	{
		return null;
	}

	public uint GetEffectiveHLMemberNum()
	{
		return 0u;
	}

	public uint GetEffectiveTrendMemberTrendNum()
	{
		return 0u;
	}

	public List<ClanTrendMsgInfo> GetClanTrendMemberInfos()
	{
		return null;
	}

	public List<MessageInfo> GetTrendMessageInfo()
	{
		return null;
	}

	public List<MessageInfo> GetMainPageTrendMessageInfo(uint limitNumber)
	{
		return null;
	}

	public void AddMessageInfo(MessageInfo mess)
	{
	}

	public void RemoveQuickAddFriendMessageInfo(EChannel.ChannelType type, ulong id, ulong senderId)
	{
	}

	public void RefreshMessageList()
	{
	}

	private void SetMessageProfileState()
	{
	}

	private void SetMessageProfileStateInternal(MessageInfo lastMessage, MessageInfo curMessage)
	{
	}

	public void RefreshTrendInfoMsgShowState()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void InitClanTrendInfo()
	{
	}

	public void RequestAddNewReactToTrendMessgae(uint emojiId, ulong clanMsgId)
	{
	}

	public void RequestClanTrendInfo(bool forceRefresh = false)
	{
	}

	private List<ClanHighLightInfo> ModifyClanHighLightInfo(List<ClanHighLightInfo> originHLInfo)
	{
		return null;
	}

	private void InitClanMsgReplyInfoShowState(List<ClanMsgInfo> ClanTrendInfo)
	{
	}

	public void RefreshClanMsgInfoNewReplyInfo(ulong msgId, uint emojiId)
	{
	}

	public ClanTrendMsgInfo GetTendMsgInfosByTrendMsgId(ulong msgId)
	{
		return null;
	}

	public ClanHighLightInfo GetClanHighLightInfoBeforeLastOpenTime()
	{
		return null;
	}

	public ClanTrendMsgInfo GetClanTrendMsgInfoBeforeLastOpenTime()
	{
		return null;
	}

	public ulong GetLastModifyAnnouncementDateStampTime()
	{
		return 0uL;
	}

	public void SetLastOpenClanTime()
	{
	}

	public void ModifyAnnounce(string announcement)
	{
	}

	private void _003CRequestClanTrendInfo_003Eb__35_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
