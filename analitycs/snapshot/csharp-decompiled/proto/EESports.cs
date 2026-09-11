namespace proto;

public class EESports
{
	public enum TeamJoinType
	{
		TeamJoinType_Free,
		TeamJoinType_Review
	}

	public enum JoinTeamReqReplyType
	{
		JoinTeamReqReplyType_Decline,
		JoinTeamReqReplyType_Approve
	}

	public enum JoinRequestSource
	{
		JoinRequestSource_None,
		JoinRequestSource_QRCode,
		JoinRequestSource_Invite
	}

	public enum RequestRateLimit
	{
		RequestRateLimit_None,
		RequestRateLimit_CreateEsportsTeam,
		RequestRateLimit_GetEsportsTeamList,
		RequestRateLimit_ModifyEsportsTeamJoinType,
		RequestRateLimit_ModifyEsportsTeamSlogan,
		RequestRateLimit_RequestJoinEsportsTeam,
		RequestRateLimit_CancelEsports
	}
}
