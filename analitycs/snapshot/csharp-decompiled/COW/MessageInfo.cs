using LitJson;
using tcp;

namespace COW;

public class MessageInfo
{
	public EChannel.ChannelType RecvType;

	public ulong RecvID;

	public ulong SenderID;

	public BaseProfileInfo SenderInfo;

	public bool KeepLocalSenderInfo;

	public EChannel.MsgType MessageType;

	public string MessageContent;

	public string OriginalContent;

	public string ExtraInfo;

	public ulong SendTimeStamp;

	public EChatMessageSendState SendState;

	public ulong GroupId;

	public EChatTipsType ChatTipsType;

	public EInteractionType InteractionType;

	public bool Reported;

	public bool IsShowProfile;

	public bool IsNeedHide;

	public uint Identities;

	public LeaderboardTitleInfo LeaderboardTitle;

	public bool IsAutoSendLuckyBuffMessage;

	public bool IsKey;

	public bool IsInteractionClick;

	public ClanTrendMsgInfo ClanTrendMsg;

	public ulong MessageId;

	public bool NeedShowProfileInClanTrend;

	public uint TitleID;

	private bool m_InitJsonData;

	public bool SenderMembershipState;

	public AntiAddictionAgeAuthInfo BRAuthInfo;

	public GuardianTextChatSetting BRTextChatSetting;

	private JsonData m_ExtraInfoJsonData;

	public ESpecialChatModeForm ChatForm => ESpecialChatModeForm.None;

	public JsonData ExtraInfoJsonData => null;

	public MessageInfo()
	{
	}

	public MessageInfo(TextMsgReq req)
	{
	}

	public void UpdateProfileInfo()
	{
	}

	public string GetSenderName()
	{
		return null;
	}

	public bool IsFastClanRecruit()
	{
		return false;
	}

	public bool IsFastGroupRecruit()
	{
		return false;
	}

	public bool IsFastClanGroupRecruit()
	{
		return false;
	}

	public bool IsFastChampionshipTeamRecruit()
	{
		return false;
	}

	public bool IsFastCupMatchTeamRecruit()
	{
		return false;
	}

	public bool IsFastBigEventMsg()
	{
		return false;
	}

	public bool IsFastRoomWinRate()
	{
		return false;
	}

	public string GetFastBigEventContent()
	{
		return null;
	}

	public bool CheckContentHasFlag(string key)
	{
		return false;
	}
}
