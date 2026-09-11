namespace tcp;

public class EChat
{
	public enum Proto
	{
		Proto_NONE,
		Proto_REPORT_CHAT,
		Proto_LIKE_MSG,
		Proto_OFFLINE_MESSAGE,
		Proto_OFFLINE_MESSAGE_NTF,
		Proto_HISTORY_MESSAGE,
		Proto_HISTORY_MESSAGE_NTF,
		Proto_INITFAIL_NTF
	}

	public enum ErrCode
	{
		ErrCode_NONE,
		ErrCode_ALREADY_MUTED,
		ErrCode_LIKEMSGLIMIT,
		ErrCode_ALREADY_MUTED_CREDIT_PUNISH_OTHER
	}
}
