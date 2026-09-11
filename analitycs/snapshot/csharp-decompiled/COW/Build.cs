using message;

namespace COW;

public static class Build
{
	public enum Domestic
	{
		Global,
		Vietnam,
		India
	}

	public const string APP_ID = "com.dts.freefireth";

	public const string FACEBOOK_APP_ID = "2036793259884297";

	public const string DATADOME_SDK_KEY = "AE3F04AD3F0D3A462481A337485081";

	public const bool IsMobileHardwareInput = false;

	public const bool IsStandaloneInput = false;

	public const string URL_SCHEME_UNIVERSAL = "freefire";

	public const string URL_SCHEME_PACKAGE = "freefireth";

	public static bool IsHPE => false;

	public static NPNFDPBMIOH ChannelType => NPNFDPBMIOH.EChannelType_DEV;

	public static MOCIMAJKKLF SystemPlatform => MOCIMAJKKLF.ESystemPlatform_IOS;

	public static LEDOHMBDIEL Architecture => LEDOHMBDIEL.EArchitecture_None;

	public static string BuildArchiveFolder => null;

	public static Domestic DomesticVariant => Domestic.Global;
}
