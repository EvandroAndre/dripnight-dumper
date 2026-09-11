using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISceneEditSearchMapController : UINavigationController, IUIModelDataChangeObserver
{
	private enum EState
	{
		WaitForSearch,
		Searching
	}

	private enum ESearchMode
	{
		Code,
		Word,
		HotWord
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UISceneEditSearchMapSearchHistoryItemController controller;

		public UISceneEditSearchMapController _003C_003E4__this;

		internal void _003CRefreshSearchHistory_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UISceneEditSearchMapHotSearchItemController controller;

		public UISceneEditSearchMapController _003C_003E4__this;

		internal void _003CRefreshHotSearch_003Eb__0()
		{
		}
	}

	private UISceneEditSearchMapView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelQRCode m_ModelQRCode;

	private List<UISceneEditSearchMapSearchHistoryItemController> m_SearchHistoryItemControllers;

	private List<UISceneEditSearchMapHotSearchItemController> m_HotSearchItemControllers;

	private List<UIUGCUnifiedMapSlot1Controller> m_HotMapItemControllers;

	private List<UIUGCUnifiedMapSlot1Controller> m_SearchedItemsItemControllers;

	private EState m_CurState;

	private ESearchMode m_SearchMode;

	private string m_SearchContent;

	private int m_HotSearchLimit;

	private int m_HotMapLimit;

	private bool m_InputFocused;

	private uint m_HelpDelayCallId;

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void CheckUGCExposure(bool force = false)
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnBtnLeaveClick()
	{
	}

	private void OnBtnSearchClick()
	{
	}

	private void OnBtnResetSearchHistoryClick()
	{
	}

	private void OnBtnRefreshHotSearchClick()
	{
	}

	private void OnBtnHelpClick()
	{
	}

	private void OnBtnClearSearchClick()
	{
	}

	private void OnBtnQRCodeScanClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void TurnToState(EState state, bool searchFailed = false)
	{
	}

	private void RefreshSearchHistory()
	{
	}

	private void RefreshHotSearch()
	{
	}

	private void RefreshHotMap()
	{
	}

	private string GenerateFromInfo(string searchContent, ESearchMode searchMode, bool isRecommendation)
	{
		return null;
	}

	private string GenerateFromInfo(bool isRecommendation)
	{
		return null;
	}

	private void RefreshClearSearchBtn()
	{
	}

	private void _003COnUIInit_003Eb__16_0()
	{
	}

	private void _003COnUIInit_003Eb__16_1()
	{
	}

	private void _003COnUIOpen_003Eb__19_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
