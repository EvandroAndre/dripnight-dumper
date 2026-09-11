namespace tcp;

public class EGin
{
	public enum Proto
	{
		Proto_NONE,
		Proto_GET_FEATURE_AND_FLAG_NTF,
		Proto_USER_LOGIN,
		Proto_USER_TICK,
		Proto_REPORT,
		Proto_CLIENT_DATA_FORWARD,
		Proto_CLIENT_DATA_FORWARD_NTF,
		Proto_GET_TOKEN,
		Proto_GET_TOKEN_NTF,
		Proto_CLIENT_VERIFY_APP_ATTEST,
		Proto_CLIENT_VERIFY_APP_ATTEST_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
