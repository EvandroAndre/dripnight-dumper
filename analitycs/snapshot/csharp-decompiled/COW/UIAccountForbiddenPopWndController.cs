using GCommon;
using proto;

namespace COW;

public class UIAccountForbiddenPopWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum AppealStatus
	{
		None,
		CanAppeal,
		Appealing,
		Appealed
	}

	protected UIAccountForbiddenPopWndView m_View;

	private string m_InfoUrl;

	private UICountDownController m_CountDownCtrl;

	private UIModelLogin m_ModelLogin;

	private UIModelOTP m_ModelOTP;

	private ulong m_AccountId;

	private uint m_Level;

	protected string m_Region;

	private EAccount.BanReason m_ReasonID;

	private uint m_ExpireDuration;

	private bool m_IsGuestAccountDeleteEnabled;

	private string m_TopNoticeText;

	private bool m_HasLoggedAppealViaRecheck;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshCountDownLabel(uint timeStamp)
	{
	}

	public void SetMessageKey(BlacklistInfoRes blackList)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnDeleteAccountBtnClick()
	{
	}

	private void OnReCheckBtnClick()
	{
	}

	private void RefreshProfileInfo(ulong accountId, string nickname, uint head_pic = 0u, uint banner_id = 0u, uint level = 0u)
	{
	}

	private void RefreshViews()
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

	private void SaveRecheckAppealTime(ulong accountId)
	{
	}

	private ulong GetRecheckExpireTime(ulong accountId)
	{
		return 0uL;
	}

	private ulong GetRandomRecheckTimeout()
	{
		return 0uL;
	}

	private AppealStatus CheckAppealStatus(ulong accountId)
	{
		return AppealStatus.None;
	}

	private bool IsGuestAccountDeleteEnabledInCurrentRegion()
	{
		return false;
	}

	private bool IsRegionInEnabledList(string region, string enabledRegions)
	{
		return false;
	}

	private void ShowDeleteGuestAccountConfirmation()
	{
	}

	private void OnConfirmDeleteGuestAccount()
	{
	}

	private void RequestOtpBindInfo()
	{
	}

	private void HandleOTPBindInfoReceived()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
