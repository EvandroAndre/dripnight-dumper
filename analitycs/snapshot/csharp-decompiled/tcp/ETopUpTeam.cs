namespace tcp;

public class ETopUpTeam
{
	public enum Proto
	{
		Proto_NONE,
		Proto_TOP_UP_TEAM_INVITE_NTF,
		Proto_TOP_UP_TEAM_PROGRESS_NTF,
		Proto_TOP_UP_TEAM_JOIN_NTF,
		Proto_TOP_UP_TEAM_LEAVE_NTF,
		Proto_TOP_UP_TEAM_ACCOUNT_TOP_UP_NTF,
		Proto_TOP_UP_TEAM_UPDATE_TEAM_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
