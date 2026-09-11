namespace proto;

public class EAuth
{
	public enum ClientUsingVersion
	{
		ClientUsingVersion_NONE,
		ClientUsingVersion_NORMAL,
		ClientUsingVersion_MAX,
		ClientUsingVersion_FFI,
		ClientUsingVersion_MAX_HPE,
		ClientUsingVersion_FFVN
	}

	public enum TokenLoginType
	{
		TokenLoginType_NONE,
		TokenLoginType_WEB,
		TokenLoginType_MOBILE,
		TokenLoginType_PC
	}

	public enum TokenAuthSource
	{
		TokenAuthSource_NONE,
		TokenAuthSource_LOGIN,
		TokenAuthSource_SWAPBINDING,
		TokenAuthSource_REGISTER,
		TokenAuthSource_GUESTBIND,
		TokenAuthSource_SECONDARYACCOUNTBIND,
		TokenAuthSource_BINDDELETE
	}
}
