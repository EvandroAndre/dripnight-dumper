using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIAchievementMainBigEventCollectionWndController : UIPopupWindowController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AchievementEntryInfo, uint> _003C_003E9__27_0;

		internal uint _003CShowDetailPopupWindow_003Eb__27_0(AchievementEntryInfo info)
		{
			return 0u;
		}
	}

	private UIAchievementMainBigEventCollectionWndView m_View;

	private List<Transform> m_ItemTransList;

	private List<UIAchievementMainBigEventItemController> m_ItemCtrlList;

	protected List<AchievementEntryInfo> m_Data;

	private UIModelProfileCustom m_ModelProfileCustom;

	private UIModelAchievement m_ModelAchivement;

	protected EBigEventCollectionWndType m_Type;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private int m_CurrentPage;

	private int m_TotalPage;

	private int m_CurrentSelectIndex;

	private uint m_CurrentCoverId;

	private bool m_IsSelf;

	private bool m_InEdit;

	private const int PAGE_NUM = 8;

	private const int PROFILE_CUSTOM_OFFSET = 20;

	protected bool m_IsCDNReady;

	protected bool m_IsGlassBGReady;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void SetViewData(List<AchievementEntryInfo> data, uint coverId, bool isSelf, bool isInEdit, EBigEventCollectionWndType type)
	{
	}

	public void SetCurrentSelectIndex(object[] data)
	{
	}

	public UIAchievementMainBigEventCollectionWndView GetView()
	{
		return null;
	}

	public void ShowDetailPopupWindow(uint bigEventId)
	{
	}

	protected void RefreshInfo(string key = "", uint completedNum = 0u, uint allNum = 0u)
	{
	}

	private void RefreshPreviewCDN()
	{
	}

	protected void RefreshBigEventView()
	{
	}

	private void RefreshBigEventScrollView()
	{
	}

	private void OnButtonCloseClick()
	{
	}

	private void UpdatePlayerBasicInfo()
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	public void UpdateBanner(BannerData bannerdata)
	{
	}

	private void RefreshPrimeAvatarFrame(BaseProfileInfo data)
	{
	}

	private void SetBigEventCollectionCover()
	{
	}

	private void _003CRefreshPreviewCDN_003Eb__29_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
