namespace tcp;

public class ECustomEvent
{
	public enum Proto
	{
		Proto_NONE,
		Proto_EVENT_ASSIST_INFO_NTF,
		Proto_CARD_RED_POINT_NTF,
		Proto_CARD_RECEIVE_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
