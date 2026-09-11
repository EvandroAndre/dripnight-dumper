namespace InterApp;

public class TwitterAppInfo : BaseAppInfo
{
	public override string[] URLSchemes_iOS => null;

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
