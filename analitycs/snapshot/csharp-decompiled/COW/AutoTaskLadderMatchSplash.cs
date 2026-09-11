using GCommon;

namespace COW;

public class AutoTaskLadderMatchSplash : AutoPopupTask
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public AutoTaskLadderMatchSplash _003C_003E4__this;

		public string cdnBgUrl;

		public NetworkDownloadEngine.OnDowloadFinished onDownloadFinished;

		public NetworkDownloadEngine.OnDownloadFailed onDownloadFailed;

		internal void _003CStartPreDownloadCdn_003Eb__0(ResultTextureInfo textureInfo)
		{
		}

		internal void _003CStartPreDownloadCdn_003Eb__1(CDNDownloadFailedInfo failedInfo)
		{
		}
	}

	private const float CdnPreloadTimeoutSeconds = 3f;

	private UILadderMatchSplashController m_SplashCtrl;

	private string m_CdnBgUrl;

	private bool m_WaitingForCdn;

	private bool m_CdnPreloadReady;

	private float m_CdnPreloadStartTime;

	private static string SplashShownKey => null;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	private void MarkSplashShown()
	{
	}

	private bool OpenSplash()
	{
		return false;
	}

	private bool ShouldShowSplash()
	{
		return false;
	}

	private void StartPreDownloadCdn()
	{
	}

	private bool IsAllCdnReady()
	{
		return false;
	}

	private bool IsRankedMatchMode(uint matchMode)
	{
		return false;
	}

	private bool IsCurrentRegionOpen()
	{
		return false;
	}

	private bool IsPlayerLevelBelowTriggerLevel()
	{
		return false;
	}

	private void Log(string format, object[] args)
	{
	}
}
