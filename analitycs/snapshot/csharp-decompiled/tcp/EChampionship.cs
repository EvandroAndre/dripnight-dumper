namespace tcp;

public class EChampionship
{
	public enum Proto
	{
		Proto_NONE,
		Proto_REQUEST_JOIN_NTF,
		Proto_CONFIRM_ADD_NTF,
		Proto_REMOVE_MEMBER_NTF,
		Proto_INVITE_NTF,
		Proto_APPROVE_INVITATION_NTF,
		Proto_DISMISS_NTF,
		Proto_MATCH_END_NTF,
		Proto_FAKE_SUBMIT_NTF,
		Proto_DECLINE_INVITATION_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
