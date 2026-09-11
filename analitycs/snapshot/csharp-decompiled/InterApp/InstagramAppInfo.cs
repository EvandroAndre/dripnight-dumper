namespace InterApp;

public class InstagramAppInfo : BaseAppInfo
{
	public override string[] URLSchemes_iOS => null;

	public override string[] BundleIdentifiers_Android => null;

	public override bool CanShareText()
	{
		return false;
	}

	public override void ShareText(string text)
	{
	}

	public override bool CanShareImage()
	{
		return false;
	}

	public override void ShareImage(string filePath)
	{
	}
}
