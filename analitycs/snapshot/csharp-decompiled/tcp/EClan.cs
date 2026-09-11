namespace tcp;

public class EClan
{
	public enum Proto
	{
		Proto_NONE = 0,
		Proto_REQUEST_JOIN_NTF = 1,
		Proto_CONFIRM_ADD_NTF = 2,
		Proto_REMOVE_MEMBER_NTF = 3,
		Proto_INVITE_NTF = 4,
		Proto_APPROVE_INVITATION_NTF = 5,
		Proto_DISMISS_NTF = 6,
		Proto_AUTO_JOIN_NTF = 7,
		Proto_NEW_LUCKY_BAG_NTF = 8,
		Proto_APPLY_FOR_DEPUTY_NTF = 9,
		Proto_DEPUTY_CAPTAIN_NTF = 10,
		Proto_CLAN_ADD_ACTIVENESS = 18,
		Proto_CLAN_GUILD_WAR_TITILE_RECEIVE_NTF = 19,
		Proto_CLAN_ADD_ACTIVENESS_NTF = 20,
		Proto_CLAN_NEW_MSG_NTF = 21,
		Proto_CLAN_REPLY_MSG_NTF = 22,
		Proto_DECLINE_APPLICATION_NTF = 23,
		Proto_PRIVILEGE_UPDATE = 24,
		Proto_GUILD_WAR_HACKER_PUNISH = 25
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
