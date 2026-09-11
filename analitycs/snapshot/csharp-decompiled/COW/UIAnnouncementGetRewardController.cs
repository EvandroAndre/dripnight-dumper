using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIAnnouncementGetRewardController : UIPopupWindowController
{
	private UIAnnouncementGetRewardViewExt m_View;

	private RewardBtn m_BtnData;

	public Dictionary<int, UIAwardItemController> m_SelectedDict;

	private int m_EquippedSuccessNum;

	private bool m_HaveShowFailTip;

	private const float m_AutoCloseSecond = 1f;

	private uint m_AutoCloseDC;

	private bool m_EnableOKBtn;

	private uint previewItemID;

	private int quality;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void ShowAwardList(List<BaseItemInfo> infoList, string reward_title = null, RewardBtn btn_data = null, string transfer_hint = null)
	{
	}

	private bool IsCanEquip(uint itemId)
	{
		return false;
	}

	private void SetEquipBtnStats(List<UIAwardItemController> awardList)
	{
	}

	private void SetEquipToggleStats(List<UIAwardItemController> awardList)
	{
	}

	private void OnFastEquipClick()
	{
	}

	private void OnOKBtnClick()
	{
	}

	private void OnBannerEquipResult(object[] data)
	{
	}

	private void OnHeadPicEquipResult(object[] data)
	{
	}

	private void OnCommonEquipResult(object[] data)
	{
	}

	private void OnClothEquipResult(object[] data)
	{
	}

	private void OnEquipSuccess()
	{
	}

	private void OnEquipFail()
	{
	}

	private void AutoClose()
	{
	}

	private void OnGoToSharePreviewClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
