using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIRecommendLoadoutWindowController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<RecommendPlanItem> _003C_003E9__48_0;

		public static Predicate<RecommendPlanItem> _003C_003E9__48_1;

		public static Func<RecommenderTabDesc, bool> _003C_003E9__53_0;

		public static Func<RecommenderTabDesc, int> _003C_003E9__53_1;

		public static Action _003C_003E9__55_2;

		public static Action _003C_003E9__55_3;

		public static Comparison<RecommendPlanItem> _003C_003E9__72_0;

		internal bool _003CInitKOLPlanListData_003Eb__48_0(RecommendPlanItem p)
		{
			return false;
		}

		internal bool _003CInitKOLPlanListData_003Eb__48_1(RecommendPlanItem p)
		{
			return false;
		}

		internal bool _003CInitTopRecommenderTab_003Eb__53_0(RecommenderTabDesc t)
		{
			return false;
		}

		internal int _003CInitTopRecommenderTab_003Eb__53_1(RecommenderTabDesc t)
		{
			return 0;
		}

		internal void _003CInitRoleFilterDropdown_003Eb__55_2()
		{
		}

		internal void _003CInitRoleFilterDropdown_003Eb__55_3()
		{
		}

		internal int _003CSortRecommendPlanList_003Eb__72_0(RecommendPlanItem a, RecommendPlanItem b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public UIRecommendLoadoutWindowController _003C_003E4__this;

		public int index;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnPlayerPlanItemClickedEvent_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UISecondConfirmContoller confirmWnd;

		public UIRecommendLoadoutWindowController _003C_003E4__this;

		internal void _003COnClickEnabledPostBtn_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public UISecondConfirmContoller confirmWnd;

		public UIRecommendLoadoutWindowController _003C_003E4__this;

		internal void _003COnClickDeletePlanBtn_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIRecommendLoadoutWindowController _003C_003E4__this;

		public UISecondConfirmContoller confirmWnd;

		internal void _003COnClickCloseBtn_003Eb__0()
		{
		}
	}

	private sealed class _003COnDescriptionLostFocusCoroutine_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIRecommendLoadoutWindowController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnDescriptionLostFocusCoroutine_003Ed__110(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const uint ALL_ROLES_ID = uint.MaxValue;

	private const int SEARCH_COOLDOWN_SEC = 5;

	private UIRecommendLoadoutWindowView m_View;

	private List<UIRecommendLoadoutWindowModeTabController> m_OfficialModeTabList;

	private List<UIRecommendLoadoutWindowModeTabController> m_KolModeTabList;

	private List<UIRecommendLoadoutWindowRecommenderTabController> m_RecommenderTabList;

	private Dictionary<uint, List<RecommendPlanItem>> m_Role2PlanList;

	private Dictionary<uint, Dictionary<uint, List<RecommendPlanItem>>> m_KOLRole2Tab2PlanList;

	private List<RecommendPlanItem> m_CurDataList;

	private UIPopMenuSmallControler m_OfficialRoleFilterDropdown;

	private UIPopMenuSmallControler m_KolRoleFilterDropdown;

	private UIConfirmPlanItemController m_PlayerEditPlanContainerCtrl;

	private UIPopMenuSmallControler m_PlayerEditPlanModeDropdownCtrl;

	private UIPopMenuSmallControler m_PlayerEditPlanRoleDropdownCtrl;

	private List<PopMenuData> m_OfficialRoleFilterMenuData;

	private List<PopMenuData> m_KolRoleFilterMenuData;

	private List<PopMenuData> m_ModeEditMenuData;

	private List<PopMenuData> m_RoleEditMenuData;

	private int m_SelectedPlayerPlanIndex;

	private UIModelLoadout m_ModelLoadout;

	private UIModelCheckNameValid m_ModelCheckNameValid;

	private UIBuildNavigationController m_BuildCtrl;

	private UIRecSelectTagPopupController m_RecSelectTagPopupCtrl;

	private List<UILoadoutTagController> m_PlayerEditTagControllerList;

	private uint m_OfficialModeTabId;

	private uint m_KOLModeTabId;

	private uint m_Role;

	private bool m_HasNewRole;

	private uint m_GoEntry;

	private bool m_GoPosUsed;

	private bool m_HasDescEverGotFocus;

	private bool m_IsCheckingDirtyWord;

	private bool m_IsSearchEnable;

	private bool m_IsSearchResult;

	private ulong m_SearchEndTime;

	private uint m_SearchCountDownCallID;

	private ERecommenderTabType m_RecommenderTabType;

	private Coroutine m_DescLostFocusActionCoroutine;

	private float m_DescLostFocusActionCoroutineTime;

	private List<string> m_InfoLackedStr;

	private bool m_IsEditingPublishedPlan;

	private PlayerEditRecPlanItem m_PublishedPlanSnapshot;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void InitData()
	{
	}

	private void InitKOLPlanListData()
	{
	}

	public bool IsCurOfficialRecommendedPlan(RecommendPlanItem plan)
	{
		return false;
	}

	private void InitOfficialPlanListData()
	{
	}

	private void SetSearchResult(bool isSearchResult)
	{
	}

	private void RefreshRecommendPanelView(bool isClearSearchInput = false)
	{
	}

	private void InitTopRecommenderTab()
	{
	}

	private void InitModeTopTab()
	{
	}

	private void InitRoleFilterDropdown()
	{
	}

	private bool CheckRequiredFields()
	{
		return false;
	}

	private void RefreshPlanPublishState(PlayerEditRecPlanItem plan)
	{
	}

	private void RefreshPlayerEditPanelData(object[] args = null)
	{
	}

	private void CloseAllEditPanelUI()
	{
	}

	private void RefreshPlayerEditPlanContainer(PlayerEditRecPlanItem planData)
	{
	}

	private void RefreshPostButtonState()
	{
	}

	private void RefreshPlayerEditPlanModeDropdown(PlayerEditRecPlanItem planData)
	{
	}

	private void RefreshPlayerEditPlanRoleDropdown(PlayerEditRecPlanItem planData)
	{
	}

	private void RefreshPlayerEditPlanNameInput(PlayerEditRecPlanItem planData)
	{
	}

	private void RefreshPlayerEditPlanDescriptionInput(PlayerEditRecPlanItem planData)
	{
	}

	private void RefreshPlayerEditPlanTagList(PlayerEditRecPlanItem planData)
	{
	}

	private void ClearPlayerEditTagControllers()
	{
	}

	private void GenerateRoleFilterMenuData(ERecommenderTabType recommenderTabType)
	{
	}

	private PopMenuData GetRoleFilterDataById(uint roleId)
	{
		return null;
	}

	private void GenerateRoleEditMenuData()
	{
	}

	private void BuildRecommendPlanData()
	{
	}

	private void SortRecommendPlanList(List<RecommendPlanItem> planList)
	{
	}

	private void SelectPlanItem()
	{
	}

	private void OnRoleFilterItemSelected(object obj)
	{
	}

	private void OnPlayerEditPlanRoleItemSelected(object obj)
	{
	}

	private void OnRoleItemClick(uint data)
	{
	}

	private void OnClickBackButton()
	{
	}

	private void OnClickSearchEntrence()
	{
	}

	private void OnClickClearButton()
	{
	}

	private void OnClickSearchButton()
	{
	}

	private void OnSearchInputChanged()
	{
	}

	private void OnSearchCountDownStarted()
	{
	}

	private void OnSearchCountDownFinished()
	{
	}

	private void SearchCountDown()
	{
	}

	private void OnClickNameInputBtn()
	{
	}

	private void OnPlayerEditPlanDescriptionInputChanged(string description)
	{
	}

	private void OnClickModeTab(uint tab, bool isFromClick = false)
	{
	}

	private void OnClickOfficialModeTab(uint tab, bool isFromClick = false)
	{
	}

	private void OnClickKOLModeTab(uint tab, bool isFromClick = false)
	{
	}

	private void OnClickRecommenderTab(uint recommenderType, bool isFromClick = false)
	{
	}

	private void OnClickAddTag()
	{
	}

	private void OnClickDisabledPostBtn()
	{
	}

	private void OnClickEnabledPostBtn()
	{
	}

	private void OnClickDeletePlanBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickEditPlanBtn()
	{
	}

	private void ExitEditingPublishedPlan(bool restoreSnapshot)
	{
	}

	private void onClickSelectPlan()
	{
	}

	private void InitPlayerEditPanel()
	{
	}

	private bool IsSeletedIndexValid()
	{
		return false;
	}

	private void SetSelectedPlayerPlan(int index)
	{
	}

	private PopMenuData FindPlayerEditPlanModeDataByGameMode(NIKKALKPIBO gameMode)
	{
		return null;
	}

	private PopMenuData GetNoSelectionModeData()
	{
		return null;
	}

	private PopMenuData GetNoSelectionRoleData()
	{
		return null;
	}

	private void GeneratePlayerEditPlanModeMenuData()
	{
	}

	private void OnPlayerEditPlanModeFilterItemSelected(object obj)
	{
	}

	private PopMenuData FindPlayerEditPlanRoleDataByRoleID(uint roleID)
	{
		return null;
	}

	private void OnDescriptionGetFocus()
	{
	}

	private void OnDescriptionLostFocus()
	{
	}

	private IEnumerator OnDescriptionLostFocusCoroutine()
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

	public void GoposWithEntryID(uint planId)
	{
	}

	public void SetBuildCtrl(UIBuildNavigationController buildCtrl)
	{
	}

	private void OnPlayerPlanItemClickedEvent(int index)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void SaveEditPlanData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnUIInit_003Eb__43_0()
	{
	}

	private void _003COnUIInit_003Eb__43_1()
	{
	}

	private void _003COnUIInit_003Eb__43_2(uint tab)
	{
	}

	private void _003COnUIInit_003Eb__43_3(uint recommenderType)
	{
	}

	private bool _003CRefreshRecommendPanelView_003Eb__52_0(RecommendPlanItem p)
	{
		return false;
	}

	private void _003CInitRoleFilterDropdown_003Eb__55_0()
	{
	}

	private void _003CInitRoleFilterDropdown_003Eb__55_1()
	{
	}

	private bool _003CInitRoleFilterDropdown_003Eb__55_4(PopMenuData item)
	{
		return false;
	}

	private bool _003CInitRoleFilterDropdown_003Eb__55_5(PopMenuData item)
	{
		return false;
	}

	private void _003CRefreshPlayerEditPlanRoleDropdown_003Eb__63_0()
	{
	}

	private void _003COnClickEnabledPostBtn_003Eb__93_1(uint schemeId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
