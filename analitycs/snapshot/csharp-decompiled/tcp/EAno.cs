namespace tcp;

public class EAno
{
	public enum Proto
	{
		Proto_NONE,
		Proto_RECV_ANTI_DATA,
		Proto_SEND_DATA_TO_CLIENT_NTF,
		Proto_LIGHT_FEATURE_NTF,
		Proto_TICK_USER,
		Proto_SEC_REPORT_FLOW,
		Proto_SEC_PLAYER_LOGIN
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
