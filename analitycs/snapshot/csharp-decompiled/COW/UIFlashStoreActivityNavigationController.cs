using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIFlashStoreActivityNavigationController : UINavigationController, IUIModelDataChangeObserver
{
	public class FlashStoreActivityNavigationData
	{
		public uint FlashStoreActivityID;

		public uint SelectGroupID;

		public uint SelectActivityID;
	}

	private sealed class _003CResetScrollViewShowGuideCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIFlashStoreActivityNavigationController _003C_003E4__this;

		public int selectedSubGroupIdx;

		private int _003CstartIdx_003E5__2;

		private UIBaseController _003CfirstController_003E5__3;

		private float _003Cprotection_003E5__4;

		private int _003CwaitCount_003E5__5;

		private WaitForSeconds _003CwaitForSeconds_003E5__6;

		private UIBaseController[] _003CcacheCtrlList_003E5__7;

		private int _003Ci_003E5__8;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetScrollViewShowGuideCoroutine_003Ed__36(int _003C_003E1__state)
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

	public const string LOG_IDENTIFIER = "FlashStoreActivityNavigation";

	private const string TITLE_DESC_KEY = "T_35_LC_FLASHSTORE_HINT1";

	private const string RULE_POPUP_TITLE_KEY = "TXT_CLAN_GENERAL";

	private const string ACTIVITIES_PANEL_DESC_KEY = "T_35_LC_FLASHSTORE_NUMBER";

	private const string GUIDE_STEP1_KEY = "FlashStoreActivity_Step1_Account{0}";

	private const string GUIDE_STEP2_KEY = "FlashStoreActivity_Step2_Account{0}";

	private const string GUIDE_STEP3_KEY = "FlashStoreActivity_Step3_Account{0}";

	private const string FLASH_GEM_SPRITE_NAME = "FF_UI_FlashStore_PurpleDiamond";

	private const string NORMAL_GEM_SPRITE_NAME = "FF_UI_FlashStore_Diamond";

	private uint m_FlashStoreActivityID;

	private uint m_SelectedActivityGroupID;

	private uint m_DelayExecuteGuidePeek;

	private UIFlashStoreActivityNavigationView m_View;

	private Coroutine m_ResetScrollViewShowGuideCoroutine;

	private readonly List<int> m_ActivitySubGroupStartIndexList;

	private readonly List<UIBaseController> m_ActivityPanelCtrlList;

	private readonly List<UIFlashStoreActivityPhaseNodeController> m_PhaseNodeCtrlList;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	public static FlashStoreActivityNavigationData GetNavigationDataExposed(List<object> rawData)
	{
		return null;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private static FlashStoreActivityNavigationData GetNavigationData(List<object> rawData)
	{
		return null;
	}

	private int GetFlashStoreActivityTypeScore(ClientActivityDesc activityDesc)
	{
		return 0;
	}

	private int GetFlashStoreActivityStateScore(uint activityID)
	{
		return 0;
	}

	private List<ClientActivityDesc> GetSortedActivityDescList()
	{
		return null;
	}

	private uint GetPhaseNodeToSelect(uint[] activityGroupIDArray, uint assignedSelectGroupID)
	{
		return 0u;
	}

	private int GetSubGroupIdxToSelect(List<ClientActivityDesc> sortedActivityDescList, uint assignedSelectActivityID = 0u)
	{
		return 0;
	}

	private void SelectPhaseNode(uint activityGroupID)
	{
	}

	private int FlashStoreActivityComparison(ClientActivityDesc x, ClientActivityDesc y)
	{
		return 0;
	}

	private void AfterPhaseNodeSelected(uint assignedSelectActivityID = 0u)
	{
	}

	private void StartResetScrollViewShowGuideCoroutine(int selectedSubGroupIdx)
	{
	}

	private IEnumerator ResetScrollViewShowGuideCoroutine(int selectedSubGroupIdx)
	{
		return null;
	}

	private void SetupDefaultState()
	{
	}

	private void OnTitleImageDownloadFinished()
	{
	}

	private void PrepareTopBarTokens()
	{
	}

	private void RefreshAllPhaseNodesAndSliderValue(uint[] activityGroupArray)
	{
	}

	private void AdjustSliderHeightOnReposition()
	{
	}

	private void RefreshTitleImage()
	{
	}

	private void RefreshTitleDescription()
	{
	}

	private void RefreshActivitiesPanel(List<ClientActivityDesc> shallowCopiedList)
	{
	}

	private void RefreshActivitiesPanelTitle()
	{
	}

	private void RefreshActivitiesPanelContent()
	{
	}

	private void RefreshActivitiesPanelReceiveAllBtn()
	{
	}

	private static void OnTopBarGemsTokenClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnReceiveAllBtnClick()
	{
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnPhaseNodeSelect(uint activityGroupID)
	{
	}

	private bool TryGetGuideStep1Widget(out UIWidget widget)
	{
		widget = null;
		return false;
	}

	private bool TryGetGuideStep2Widget(out UIWidget widget)
	{
		widget = null;
		return false;
	}

	private bool TryGetGuideStep3Widget(out UIWidget widget)
	{
		widget = null;
		return false;
	}

	private void StopGuideQueue()
	{
	}

	private void PrepareGuideDataQueue()
	{
	}

	private void StartDelayExecuteGuidePeek()
	{
	}

	private void DelayExecuteGuidePeek()
	{
	}

	private void PopAndExecuteNext()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
