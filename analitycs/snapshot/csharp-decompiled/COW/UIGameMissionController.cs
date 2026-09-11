using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIGameMissionController : UIBaseController
{
	private enum Tab
	{
		NotSpecific,
		Mission,
		GameplayAffix,
		Legend,
		FFWSFlagActivity
	}

	private enum MissionDirection
	{
		Left,
		Right
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public uint missionID;

		internal bool _003COnGameMissionClose_003Eb__0(UIGameMissionBigMapInfoController x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public uint missionID;

		internal bool _003COnGameMissionUIChanged_003Eb__0(UIGameMissionBigMapInfoController x)
		{
			return false;
		}
	}

	private sealed class _003CRefreshGameplayAffixTabContent_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIGameMissionController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshGameplayAffixTabContent_003Ed__57(int _003C_003E1__state)
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

	private bool m_HideAffixTab;

	private bool m_FirstInGame;

	private bool m_CacheFlag;

	private const int MISSION_WIDTH = 272;

	private const int MISSION_TOTAL_WIDTH = 326;

	private const int GAMEPLAY_AFFIX_TAB_BG_ANCHOR_BOTTOM_OFFSET = -10;

	private bool m_RoutePlanningLegendItemLoaded;

	private UIGameMissionView m_View;

	private MissionDirection m_Direction;

	private Vector3 m_ArrowStartPos;

	private List<string> m_LegendDataList;

	private IGameMissionTopEventUI m_CurTopEventUI;

	private List<UIGameMissionBigMapInfoController> m_MissionCtrlList;

	private List<UIHudBigMapGameplayAffixDetailItemController> m_ItemCtrlList;

	private List<UIHudMapLegendItemController> m_LegendItemList;

	public UIHudMapLegendItemController ShopLegendItemCtrl;

	public UIHudMapLegendItemController AirLineLegendItemCtrl;

	private UIFFWSFlameBigMapInfoController m_FFWSFlameBigMapInfoController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnGameMissionStart(object[] data)
	{
	}

	public void OnGameMissionClose(uint missionID)
	{
	}

	private void OnGameMissionUIChanged(object[] data)
	{
	}

	private void OnGameGlobalMissionStart(object[] data)
	{
	}

	private void OnGlobalMissionEnd(object[] data)
	{
	}

	private static int SortMission(Transform trans1, Transform trans2)
	{
		return 0;
	}

	private static Tab GetTargetTabWithCarouselState(UIHudGameplayModifierCarouselItemViewData.Source state)
	{
		return Tab.NotSpecific;
	}

	private T OpenTopEventUI<T>(object data) where T : UIBaseController, IGameMissionTopEventUI
	{
		return null;
	}

	private bool IsMapLegendOpen()
	{
		return false;
	}

	private bool HasMission()
	{
		return false;
	}

	private bool HasVisibleLegendInformation()
	{
		return false;
	}

	private bool HasVisibleInformation()
	{
		return false;
	}

	private bool NeedShowFFWSFlagInfo()
	{
		return false;
	}

	private Tab GetDefaultTabWithStatus()
	{
		return Tab.NotSpecific;
	}

	private void SetupContentRootDefaultState()
	{
	}

	private void SetupMissionTabDefaultState()
	{
	}

	private void CheckIsOpenUpgradeGemSrcUI()
	{
	}

	private void UpdateGameplayAffixTabIconState(bool defaultStyle)
	{
	}

	private void ResetGameplayAffixContentAllRootY()
	{
	}

	private void SetupGameplayAffixTabDefaultState()
	{
	}

	private void CheckTutorialOnMissionTabShown()
	{
	}

	public void RefreshMissionCtrlList()
	{
	}

	private void RefreshMissionTabContent()
	{
	}

	private void TryInsertRoutePlanningLegendItemOnce(bool hasPreviousItems)
	{
	}

	public void SetLegendTabData(List<string> dataList)
	{
	}

	private void RefreshLegendTabContent()
	{
	}

	private void TryLoadMissionAffixesFromContext()
	{
	}

	private void LoadAllMissionAffixesFromContext()
	{
	}

	private void LoadAllGameplayAffixItems(uint[] pickedAffixes)
	{
	}

	private IEnumerator RefreshGameplayAffixTabContent()
	{
		return null;
	}

	private void DelayRefreshGameplayAffixTabContent()
	{
	}

	private void TryOpenTopEventOnGameplayAffixTab()
	{
	}

	private void SetTabSelectState(Tab targetTab)
	{
	}

	private void SelectAndPopulateTab(Tab targetTab = Tab.NotSpecific)
	{
	}

	private void RefreshFFWSFlagContent()
	{
	}

	private void ToggleDetailContent(bool expand)
	{
	}

	private void OnDetailContentBtnClick(bool value)
	{
	}

	private void OnTabBtnClick(Tab tabType)
	{
	}

	private void AddEventDelegates()
	{
	}

	public void RepopulateContentWhenOpenMap()
	{
	}

	public void SelectLegendTabWhenOpenMap()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_0()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_1()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_2()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_3()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_4()
	{
	}

	private void _003CAddEventDelegates_003Eb__66_5()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
