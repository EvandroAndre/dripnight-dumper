using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelSplashBanner : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<SplashBannerInfo> _003C_003E9__16_0;

		internal int _003CSetSplashBannerData_003Eb__16_0(SplashBannerInfo a, SplashBannerInfo b)
		{
			return 0;
		}
	}

	public const uint PropID_SplashBannerRetOK = 2u;

	public const uint PropID_SplashBannerRetFail = 4u;

	public const uint PropID_SplashBannerRetEmpty = 4u;

	public const uint PropID_SplashBannerGetInfo = 8u;

	public static string FULLSCREENCDNDONTSHOWKEY;

	public static string NORMALCDNDONTSHOWKEY;

	public static string PlayerPrefls_SplashPopUpTime;

	private List<SplashBannerInfo> m_SplashBannerDataList;

	private bool _003CIsSplanBannerShowed_003Ek__BackingField;

	public List<SplashBannerInfo> SplashBannerDataList => null;

	public bool IsSplanBannerShowed
	{
		get
		{
			return _003CIsSplanBannerShowed_003Ek__BackingField;
		}
		set
		{
			_003CIsSplanBannerShowed_003Ek__BackingField = value;
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetSplashBannerData(HttpErrorCode errorCode, SplashBannerDescList res)
	{
	}

	private List<SplashBannerDesc> BeforeProcessSplashCDN(List<SplashBannerDesc> splashCDNs)
	{
		return null;
	}

	private void PreDownloadSplashCdn(List<SplashBannerDesc> descList)
	{
	}

	private bool CheckThisSplashCanShowByPopupTime(SplashBannerDesc des)
	{
		return false;
	}

	public void RecordSplashPopup(uint splashBannerID)
	{
	}

	private void RandomPickSplashBannerByWeight(int maxCount, List<SplashBannerDesc> splashBanners)
	{
	}

	public SplashBannerInfo GetUnShowedSplash()
	{
		return null;
	}

	public bool CheckSplashBannerCdnDownloaded(SplashBannerInfo info)
	{
		return false;
	}

	public string GetSplashShowUrlBySplashDesc(SplashBannerDesc infoDesc)
	{
		return null;
	}

	public bool CheckCdnCanShow(SplashBannerInfo info)
	{
		return false;
	}

	public bool HaveShowedWebViewBannerToday()
	{
		return false;
	}

	public void SetShowWebViewSplashBannerTime()
	{
	}

	public bool CheckCanShowByAccountID(string lastNums)
	{
		return false;
	}

	public static bool LobbyShowWaitSplashData()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
