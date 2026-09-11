namespace tcp;

public class ECreditScore
{
	public enum Proto
	{
		Proto_NONE,
		Proto_CREDIT_SCORE_CHANGE_NTF,
		Proto_TEAMMATE_MUTED_NTF,
		Proto_REPORT_FEEDBACK_NTF,
		Proto_ROOM_PUNISH_NTF,
		Proto_PUNISH_OTHERS_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
