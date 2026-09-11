using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIRelayMartDiscountCodeShareController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private UIRelayMartDiscountCodeShareView m_View;

	private UIModelFriends m_ModelFriends;

	private UIModelShare m_ModelShare;

	private UIModelQRCode m_ModelQRCode;

	private List<FriendAccountInfoData> m_CachedFriends;

	private bool m_IsShowClanIcon;

	private ulong m_LastBtnRefreshTime;

	private ulong m_LastOpenRefreshTime;

	private bool m_HasSearch;

	private uint m_WinkCall;

	private string m_CurrentDiscountCode;

	private bool m_IsShrinkScrollViewRegion;

	private List<ulong> m_SharedFriendAccountIds;

	private bool m_HasSharedToClan;

	private bool m_HasSharedOutSide;

	public string CurrentDiscountCode => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnEnable()
	{
	}

	public void SetCurrentDiscountCode(string discountCode)
	{
	}

	public void OpenShareList()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void UpdateRefreshState(bool inCD = false)
	{
	}

	private void SetFriendUIData()
	{
	}

	private int CompareFriendListInfo(FriendAccountInfo curInfo, FriendAccountInfo nextInfo)
	{
		return 0;
	}

	private List<FriendAccountInfoData> GetFriendAccountInfoData(List<FriendAccountInfo> list)
	{
		return null;
	}

	private void OnMaskClick()
	{
	}

	public override void Hide()
	{
	}

	private void OnSearchInputChange()
	{
	}

	private void ResetSearchInput()
	{
	}

	private void RefreshScrollView()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnSearchInputGetFocus()
	{
	}

	public void RecordShareEventLog(ERelayMartDiscountCodeShareChannelType shareScene, ulong accountId)
	{
	}

	protected override void OnUIClose()
	{
	}

	private void SendRelayMartShareCouponLogs()
	{
	}

	private void RefreshShareButtonVisibility()
	{
	}

	private void RefreshScrollViewRegion()
	{
	}

	private string GetEncodedShareCode()
	{
		return null;
	}

	private void OnLineShareClick()
	{
	}

	private void OnFBShareClick()
	{
	}

	private void OnWhatsAppShareClick()
	{
	}

	private void OnInstagramShareClick()
	{
	}

	private void DoneExternalShare(EventLogger.SharePlatform sharePlatform)
	{
	}

	private void _003COnRefreshBtnClick_003Eb__26_0()
	{
	}

	private void _003COnSearchBtnClick_003Eb__36_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
