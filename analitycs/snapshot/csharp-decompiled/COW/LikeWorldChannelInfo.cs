using tcp;

namespace COW;

public class LikeWorldChannelInfo
{
	public ulong m_ChannelID;

	public uint m_LeftTalkTimesDefault;

	public uint m_LeftTalkTimesFast;

	public uint m_DailyMsgLimitDefault;

	public uint m_DailyMsgLimitFast;

	public bool m_EnableCustomMsg;

	public uint m_LevelLimit;

	public bool m_UnbindLimit;

	public EChannel.ChannelType m_ChannelType;

	public ulong m_LastUpdateTimesLimitTs;

	public ulong m_LastSendTs;

	public ulong m_LastJoinChannelTimeStamp;

	public static ulong JOIN_CHANNEL_CD;

	public static int SERVER_UPDATE_HOUR;

	public static implicit operator LikeWorldChannelInfo(JoinGeneralChanNtf info)
	{
		return null;
	}

	public static implicit operator LikeWorldChannelInfo(JoinFreshChanNtf info)
	{
		return null;
	}

	public static implicit operator LikeWorldChannelInfo(JoinWorldChanNtf info)
	{
		return null;
	}

	public void SetLikeWorldChatLeftTimes(uint leftTalk, uint leftFast)
	{
	}

	public bool IsLikeWorldTimesLimit(EChannel.MsgType msgType)
	{
		return false;
	}

	public bool IsEnableCustomTalk()
	{
		return false;
	}

	public void SetLeftFastTimesDown()
	{
	}

	public void SetLeftTalkTimesDown()
	{
	}

	public void SetLastSendTs(ulong time)
	{
	}

	public void ResetLastJoinChannelTimeStamp()
	{
	}
}
