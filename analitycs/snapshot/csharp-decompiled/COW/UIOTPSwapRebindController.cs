using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIOTPSwapRebindController : UIBaseController, IUIModelDataChangeObserver
{
	private UIOTPSwapRebindView m_View;

	private UIModelLogin m_ModelLogin;

	private UIModelOTP m_ModelOTP;

	private bool IsSendOTPChangeBindLog;

	private Dictionary<int, bool> m_PlatformSupportSignin;

	public static List<int> SpriteList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshData(ulong accountid, string nickname, uint head_pic = 0u, uint banner_id = 0u, uint level = 0u)
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	private void UpdateBanner(BannerData bannerData)
	{
	}

	private void UpdateHeadPic(uint headpic)
	{
	}

	private void InitBindPlatformDict(string swappingRegion)
	{
	}

	private void CheckPlatformBtnState(string swappingRegion, PlatformType platformType)
	{
	}

	private bool CheckPlatformBindBtnCanShow(PlatformType platformType)
	{
		return false;
	}

	private void RefreshChannel()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
