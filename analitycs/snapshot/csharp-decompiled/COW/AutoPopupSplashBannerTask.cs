namespace COW;

public class AutoPopupSplashBannerTask : AutoPopupTask
{
	private SplashBannerInfo m_NextBannerInfo;

	private bool m_AllSplashUIClose;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override bool Do()
	{
		return false;
	}

	private void OnSplashBannerItemClose(bool lateShow = false)
	{
	}

	private void ShowSplashBannerItem(SplashBannerInfo info)
	{
	}
}
