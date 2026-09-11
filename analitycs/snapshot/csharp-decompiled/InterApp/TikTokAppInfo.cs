using System;

namespace InterApp;

public class TikTokAppInfo : BaseAppInfo
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public Action<int, string> callback;

		internal void _003CShareVideo_003Eb__0(int code, string _msg)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public int code;

		public string _msg;

		public _003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals1;

		internal void _003CShareVideo_003Eb__1()
		{
		}
	}

	public static readonly string URL_SCHEME;

	public override string[] URLSchemes_iOS => null;

	public override string URLScheme_Android => null;

	public override string[] BundleIdentifiers_Android => null;

	public override bool CanLaunch()
	{
		return false;
	}

	public override bool CanShareVideo()
	{
		return false;
	}

	public override void ShareVideo(string identifier, Action<int, string> callback = null)
	{
	}
}
