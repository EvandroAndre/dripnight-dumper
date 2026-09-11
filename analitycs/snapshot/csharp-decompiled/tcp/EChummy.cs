namespace tcp;

public class EChummy
{
	public enum Proto
	{
		Proto_NONE,
		Proto_REQUEST_NTF,
		Proto_CONFIRM_ADDING_CHUMMY_NTF,
		Proto_CHUMMY_STATE_CHANGE,
		Proto_CHUMMY_DISMISSED,
		Proto_INTIMACY_CHANGE_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
