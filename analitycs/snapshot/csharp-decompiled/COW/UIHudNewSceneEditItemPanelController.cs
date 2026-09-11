using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudNewSceneEditItemPanelController : UIHudUGCTutorialRestrictionBaseController, IEasyList, IUIModelDataChangeObserver
{
	private class AIAssistSearchResp
	{
		public AIAssistItemQueryResult response;
	}

	private class AIAssistItemQueryResult
	{
		public List<AIAssistItem> query_result;
	}

	private class AIAssistItem
	{
		public uint ItemID;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__38_4;

		public static EventDelegate.Callback _003C_003E9__38_5;

		public static Func<UIHudNewSceneEditTabController, UIToggleButton> _003C_003E9__42_0;

		public static Action _003C_003E9__46_0;

		public static Comparison<KeyValuePair<string, WorkShopPrefabResourceContentConfigData>> _003C_003E9__133_0;

		public static Func<UIHudNewSceneEditTabController, UIToggleButton> _003C_003E9__134_0;

		internal void _003COnUIInit_003Eb__38_4()
		{
		}

		internal void _003COnUIInit_003Eb__38_5()
		{
		}

		internal UIToggleButton _003CUpdatePrefabList_003Eb__42_0(UIHudNewSceneEditTabController i)
		{
			return null;
		}

		internal void _003COnCreatorLvTipClick_003Eb__46_0()
		{
		}

		internal int _003CSearchItem_003Eb__133_0(KeyValuePair<string, WorkShopPrefabResourceContentConfigData> a, KeyValuePair<string, WorkShopPrefabResourceContentConfigData> b)
		{
			return 0;
		}

		internal UIToggleButton _003CUpdateSearchList_003Eb__134_0(UIHudNewSceneEditTabController i)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public UIHudNewSceneEditItemPanelController _003C_003E4__this;

		public uint optionID;

		internal bool _003COnSubTabSelect_003Eb__0(UIHudSceneEditItem item)
		{
			return false;
		}

		internal bool _003COnSubTabSelect_003Eb__1(UIHudSceneEditItem e)
		{
			return false;
		}

		internal bool _003COnSubTabSelect_003Eb__2(UIHudSceneEditItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass62_1
	{
		public UIHudSceneEditItem item;

		internal bool _003COnSubTabSelect_003Eb__3(UIHudSceneEditItem e)
		{
			return false;
		}
	}

	private UIHudNewSceneEditItemPanelView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private HNDHJGJILHC m_Game;

	private int m_SelectedTab;

	private int m_RevertSelectTab;

	private uint mSelectOptionID;

	private List<UIHudNewSceneEditTabController> m_TabControllers;

	private UIHudNewScenenEditSubTabController m_GuidSubTypeTab;

	private UIHudNewSceneEditItemTipsPopController m_ItemTipsCtrl;

	private bool m_IsShown;

	private bool m_NeedRefresh;

	private bool m_IsFold;

	private bool m_SwitchedFold;

	private bool m_IsPaintMode;

	private int m_SelectedIndex;

	private int m_RevertSelectedIndex;

	private UIHudNewSceneEditItemContainerController mSelectedController;

	private Dictionary<uint, bool> PrefabsShowTutorial;

	private uint m_DelayCallGuide1;

	private uint m_DelayCallGuide2;

	private int m_CurUserMaxCost;

	private bool m_CostExceedLimit;

	private bool m_IsFromFoldSearch;

	private bool m_IsFromFoldSearchClear;

	private float m_ItemListShrinkScrollViewOffSet;

	private bool m_RestrictionSystemReady;

	private SceneEditAgent m_Agent;

	private List<UIHudSceneEditItem> m_DataList;

	private bool m_NeedWaitDownloadFinish;

	private bool mNeedRefreshSubTab;

	private bool m_IsAISearchTab;

	private string last_ai_input;

	private bool is_ai_request_done;

	private List<UIHudSceneEditItem> m_AIDataList;

	private int searchSelectNum;

	private string lastSearchInput;

	private List<WorkShopPrefabResourceContentConfigData> m_TmpConfigDatas;

	private double LastSearchTime;

	private List<WorkShopPrefabResourceContentConfigData> m_SearchResult;

	private List<KeyValuePair<uint, string>> m_SearchNameCache;

	private List<uint> tmp_itemids;

	public UIHudNewSceneEditItemContainerController SelectedController
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SceneEditAgent Agent => null;

	public int SelectedIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MainTabCount => 0;

	public int SelectedMainTabIndex => 0;

	private List<WorkShopPrefabResourceContentConfigData> TmpConfigDatas => null;

	private List<WorkShopPrefabResourceContentConfigData> SearchResult => null;

	private List<KeyValuePair<uint, string>> SearchNameCache => null;

	private List<uint> TmpItemIDs => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshToggleButtonRestrictions()
	{
	}

	public void UpdatePrefabList()
	{
	}

	private void OnBtnPopUp()
	{
	}

	public void PFoldSelf()
	{
	}

	public void PopUpOrFold()
	{
	}

	private void OnCreatorLvTipClick()
	{
	}

	private void OnInputGetFocus()
	{
	}

	private void OnInputLostFocus()
	{
	}

	private void OnFoldInputGetFocus()
	{
	}

	private void OnFoldInputLostFocus()
	{
	}

	private void OnBtnFolder()
	{
	}

	private void ResetShrinkOffset()
	{
	}

	private void ApplyShrinkOffset(float H)
	{
	}

	private void RefreshOptionButtons()
	{
	}

	private void ResetItemSelect()
	{
	}

	private void RefreshItemSelect()
	{
	}

	private void OnSelectTab(UIToggleButton button)
	{
	}

	private void OnSubTabRefresh()
	{
	}

	private void OnCameraModeChange()
	{
	}

	private void OnCancelPutDownObj(object[] data)
	{
	}

	private void OnSubTabSelect(object[] data)
	{
	}

	private void OnSelectItem(object[] data)
	{
	}

	private void ApplyNewSelection(UIEasyList easyList, int selectedIndex, bool bForbidden)
	{
	}

	private void RefreshTabNew()
	{
	}

	private void OnTipsClick(object[] data)
	{
	}

	private void OnEditClick(object[] data)
	{
	}

	public void SelectCurrentItemContainer()
	{
	}

	private void OnCancelAdd()
	{
	}

	private void UnSelectItem(bool fold)
	{
	}

	private void OnHandleSceneEditRefresh(object[] data)
	{
	}

	private void OnHandleSceneEditAddPrefab(object[] data)
	{
	}

	private void OnHandleSceneEditRemovePrefab(object[] data)
	{
	}

	private void OnHandleSceneEditUndoRemovePrefab(object[] data)
	{
	}

	private void UpdateCost()
	{
	}

	private void CheckCostExceedLimit()
	{
	}

	private void OnOtherPanelToggle(object[] data)
	{
	}

	private void OnMoreSettingAppear(object[] data)
	{
	}

	private void OnSkyBoxAppear(object[] data)
	{
	}

	private void OnPaintModePanelAppear()
	{
	}

	private void OnItemGenPanelAppear()
	{
	}

	private void OnSelectionModeChanged()
	{
	}

	private void OnSelectDesignatedItem(object[] data)
	{
	}

	private bool CheckShowTutorial(uint prefabID)
	{
		return false;
	}

	private void OnPaintModeChange(bool value)
	{
	}

	private void OnModeTemplateChanged(object[] data)
	{
	}

	private void RefreshDataForCurrentSelection()
	{
	}

	private void ShowPointDragTutorial(object[] data)
	{
	}

	private void Tutorial2()
	{
	}

	private void HideSelf()
	{
	}

	public void ShowOrHideSearch()
	{
	}

	private void ShowSelf()
	{
	}

	private void RefreshCurrentUIState()
	{
	}

	private void RepositionSliderAndMoveToTab(int tabIndex)
	{
	}

	public void EnterPaintMode()
	{
	}

	public void ExitPaintItemMode()
	{
	}

	public Transform GetOutRangeTrans()
	{
		return null;
	}

	public UISprite GetSpriteBG()
	{
		return null;
	}

	public void SelectMainTabByIndex(int index)
	{
	}

	public UIScrollView GetSliderScrollView()
	{
		return null;
	}

	public UIWidget GetMainTabWidget(int tabIndex)
	{
		return null;
	}

	public UIWidget FindItemCellWidget(uint prefabId)
	{
		return null;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnSearchBtnClick(bool from_input)
	{
	}

	private void SaveCurrentSelect()
	{
	}

	private void RevertPrevSelect()
	{
	}

	public bool CheckSearchDuringCD()
	{
		return false;
	}

	private void PostAIRequest(string input)
	{
	}

	private void SearchItem(string inputName)
	{
	}

	public void UpdateSearchList()
	{
	}

	private void LogSearchSelectItem(uint itemid)
	{
	}

	private void LogSearch()
	{
	}

	public void ShowTweenEffect()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnUIInit_003Eb__38_0()
	{
	}

	private void _003COnUIInit_003Eb__38_1()
	{
	}

	private void _003COnUIInit_003Eb__38_2()
	{
	}

	private void _003COnUIInit_003Eb__38_3()
	{
	}

	private void _003COnUIInit_003Eb__38_6(object[] data)
	{
	}

	private void _003COnUIInit_003Eb__38_7(object[] data)
	{
	}

	private void _003CShowPointDragTutorial_003Eb__88_0()
	{
	}

	private void _003CTutorial2_003Eb__89_0()
	{
	}

	private void _003CPostAIRequest_003Eb__126_0(DOEOGBNPNAJ giError, ELLGAABJFFP giWarning, byte[] respData)
	{
	}

	private int _003Cget_SearchNameCache_003Eb__132_0(WorkShopPrefabResourceContentConfigData a, WorkShopPrefabResourceContentConfigData b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
