namespace InterApp;

public class LineAppInfo : BaseAppInfo
{
	public static readonly string URL_SCHEME;

	private const string ANDROID_PACKAGE_NAME = "jp.naver.line.android";

	private const string ANDROID_SEND_TO_ACTIVITY_NAME = "com.linecorp.line.share.common.view.FullPickerLaunchActivity";

	public override string[] URLSchemes_iOS => null;

	public override string URLScheme_Android => null;

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
