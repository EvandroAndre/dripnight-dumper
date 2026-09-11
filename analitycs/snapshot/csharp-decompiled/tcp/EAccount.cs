namespace tcp;

public class EAccount
{
	public enum Proto
	{
		Proto_NONE,
		Proto_MULTILOGIN_NTF,
		Proto_INVALID_CLIENT_VERSION_NTF,
		Proto_ACCOUNT_IN_BLACKLIST_NTF,
		Proto_ACCOUNT_LEVEL_UP_NTF,
		Proto_ACCOUNT_ROLE_CHANGED_NTF,
		Proto_ACCOUNT_DELETED_NTF,
		Proto_ACCOUNT_BAN_BY_NEW_VERSION_NTF,
		Proto_ACCOUNT_DISABLE_OTHER_REGION,
		Proto_ACCOUNT_LIKED,
		Proto_ACCOUNT_MIC_MUTE,
		Proto_INITFAIL_NTF,
		Proto_ACCOUNT_NEW_BADGE
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
