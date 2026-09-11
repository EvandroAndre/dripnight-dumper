namespace tcp;

public class EChannel
{
	public enum Proto
	{
		Proto_NONE = 0,
		Proto_TEXT_MSG = 1,
		Proto_TEXT_MSG_NTF = 2,
		Proto_JOIN_CHANNEL = 3,
		Proto_LEAVE_CHANNEL = 4,
		Proto_JOIN_WORLD_CHAN_NTF = 5,
		Proto_LEAVE_CHANNEL_NTF = 7,
		Proto_JOIN_FRESH_CHAN_NTF = 8,
		Proto_TOP_NEWBIE_RANKING_POINTS_DELTA = 9
	}

	public enum ErrCode
	{
		ErrCode_SUSS = 0,
		ErrCode_INVALIDCHANNELTYPE = 1,
		ErrCode_ALREADYINCHANNEL = 2,
		ErrCode_CREATEPLAYERFAIL = 3,
		ErrCode_CREATECHANNELFAIL = 4,
		ErrCode_MAXMEMBERLIMIT = 5,
		ErrCode_NOCHANNEL = 6,
		ErrCode_NOTINCHANNEL = 7,
		ErrCode_REACHMSGLIMIT = 8,
		ErrCode_WORLDCHANNELDISABLED = 9,
		ErrCode_CUSTOMMSGDISABLED = 10,
		ErrCode_RESERVATIONREACHLIMIT = 11,
		ErrCode_INVALIDCHANNELSECRET = 12,
		ErrCode_ALLOCATEWORLDCHANNELFAIL = 13,
		ErrCode_ALLOCATEFRESHCHANNELFAIL = 15,
		ErrCode_FRESHCHANNELDISABLED = 16,
		ErrCode_NOTFRESHER = 17,
		ErrCode_FRESHREACHMSGLIMIT = 18,
		ErrCode_FRESHCUSTOMMSGDISABLED = 19
	}

	public enum ChannelType
	{
		ChannelType_GROUP = 0,
		ChannelType_CLAN = 1,
		ChannelType_WHISPER = 2,
		ChannelType_ROOM = 3,
		ChannelType_CHAMPIONSHIPTEAM = 4,
		ChannelType_WORLD = 5,
		ChannelType_GROUP_FAST = 6,
		ChannelType_CUP = 7,
		ChannelType_SERIES_TEAM = 8,
		ChannelType_SOCIAL_AREA = 10,
		ChannelType_FRESH = 11,
		ChannelType_MAX = 12
	}

	public enum MsgType
	{
		MsgType_DEFAULT,
		MsgType_FAST,
		MsgType_STICKY_SPEAKER,
		MsgType_RESERVATION,
		MsgType_INTERACTION,
		MsgType_FRIEND_CALLBACK,
		MsgType_USER_INPUT
	}

	public enum MsgLimitType
	{
		MsgLimitType_DEFAULT,
		MsgLimitType_FAST
	}
}
