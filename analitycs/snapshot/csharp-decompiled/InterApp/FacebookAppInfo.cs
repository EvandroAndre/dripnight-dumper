namespace InterApp;

public class FacebookAppInfo : BaseAppInfo
{
	public static readonly string URL_SCHEME;

	public override string[] URLSchemes_iOS => null;

	public override string URLScheme_Android => null;

	public override string[] BundleIdentifiers_Android => null;

	public override bool CanShareText()
	{
		return false;
	}

	public override bool CanShareImage()
	{
		return false;
	}
}
