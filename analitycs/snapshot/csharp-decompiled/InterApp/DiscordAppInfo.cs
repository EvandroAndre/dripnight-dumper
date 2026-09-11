namespace InterApp;

public class DiscordAppInfo : BaseAppInfo
{
	public static readonly string URL_SCHEME;

	public override string[] URLSchemes_iOS => null;

	public override string URLScheme_Android => null;

	public override string[] BundleIdentifiers_Android => null;

	public override bool CanShareVideo()
	{
		return false;
	}

	public override bool CanShareImage()
	{
		return false;
	}

	public override bool CanShareText()
	{
		return false;
	}
}
