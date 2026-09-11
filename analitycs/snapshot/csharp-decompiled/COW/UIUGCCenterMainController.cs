using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCenterMainController : UINavigationController, IUIModelDataChangeObserver
{
	public enum ETabIndex
	{
		Recommend = 0,
		Rank = 1,
		Explore = 2,
		Activity = 3,
		Editor = 99,
		None = 999
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__40_0;

		public static Action _003C_003E9__59_0;

		internal void _003COnUIInit_003Eb__40_0()
		{
		}

		internal void _003CCanOpenEditorTab_003Eb__59_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public UIUGCCenterMainController _003C_003E4__this;

		public int value;

		public Action onComplete;

		internal void _003CCheckFirstViperGuide_003Eb__0()
		{
		}
	}

	public static readonly string Key_GuideUserTab_Lobby_Format;

	public static readonly string Key_Guide_UGCCenter_FirstEnter;

	private static bool _003CIsFirstEnterGuideSession_003Ek__BackingField;

	private static bool _003CIsAutoPopupSession_003Ek__BackingField;

	private static ETabIndex _003CCurrentSelectedTab_003Ek__BackingField;

	private AutoPopup m_AutoPopup;

	private UIUGCCenterMainView m_View;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelUGCPremium m_UGCPremiumModel;

	private UIModelQRCode m_ModelQRCode;

	private UIUGCCenterRecommendController m_RecommendCtrl;

	private UIUGCCenterRankController m_RankCtrl;

	private UIUGCCenterExploreController m_ExploreCtrl;

	private UIUGCMyWorksV2Controller m_MyWorksCtrl;

	protected UIRoomCardListController m_RoomCardCtrl;

	private ETabIndex m_SelectedTab;

	private List<WorkShopCollaborationResources> m_CollaborateResList;

	private UGCSimpleDownloadTask m_NecessaryResDownloadTask;

	private uint m_HideVFXDelayCall;

	private int m_NewVersionGuideStep;

	private uint m_GuideDelayCallId;

	private UICommonGuideController m_GuideCtrl1;

	private UICommonGuideController m_GuideCtrl2;

	private UICommonGuideController m_GuideCtrl3;

	private UIHudUGCTutorialMaskController m_GuideMaskCtrl;

	private bool m_PendingPopUpTask;

	public static bool IsFirstEnterGuideSession
	{
		get
		{
			return _003CIsFirstEnterGuideSession_003Ek__BackingField;
		}
		private set
		{
			_003CIsFirstEnterGuideSession_003Ek__BackingField = value;
		}
	}

	public static bool IsAutoPopupSession
	{
		get
		{
			return _003CIsAutoPopupSession_003Ek__BackingField;
		}
		private set
		{
			_003CIsAutoPopupSession_003Ek__BackingField = value;
		}
	}

	public static ETabIndex CurrentSelectedTab
	{
		get
		{
			return _003CCurrentSelectedTab_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentSelectedTab_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static UINavigationUtil.UINavigationFrom GetTabTargetNavigationFrom(ETabIndex tabIndex)
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	private void Update()
	{
	}

	private void TryFinishAutoPopupSession()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void InitUGCCratorLv()
	{
	}

	private void TryOpenCratorLevelUpPopupIfNeeded()
	{
	}

	private void OnCreatorLevelBtnClick()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void TryRestoreUGCUserCenterWhenOpen(UINavigationData navigationData, bool restore)
	{
	}

	private void InitTabs()
	{
	}

	private bool SelectTab(ETabIndex tabIndex)
	{
		return false;
	}

	private UINavigationUtil.UINavigationFrom GetCurrentTabNavigationFrom()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	private void OnSelectTab(UIToggleButton button)
	{
	}

	private void ShowTab(ETabIndex index)
	{
	}

	private void ShowEditorTab()
	{
	}

	private void SwitchEntrance(ETabIndex index)
	{
	}

	public static bool CanOpenEditorTab(bool showTips = true, ETabIndex tabType = ETabIndex.None)
	{
		return false;
	}

	private bool CanClickEditorTab()
	{
		return false;
	}

	private bool CanClickNonEditorTab()
	{
		return false;
	}

	public bool IsShowEditor()
	{
		return false;
	}

	public void SelectEditorTab()
	{
	}

	private void OnShowRecommendView(object[] data)
	{
	}

	private void InitEntranceButtons()
	{
	}

	private void OnSearchBtnClick()
	{
	}

	private void OnEventBtnClick()
	{
	}

	private void OnMissionBtnClick()
	{
	}

	private void OnUserBtnClick()
	{
	}

	private void OnUpdatePersonServer()
	{
	}

	private void RefreshUserCenterRedPoint()
	{
	}

	private void OnCreatorCenterBtnClick()
	{
	}

	private void OnRoomBtnClick()
	{
	}

	private void OnUpdateBtnClick()
	{
	}

	private void RefreshMissionBtn()
	{
	}

	private void OnUnActiveSceneEditBtnClick()
	{
	}

	private void UpdateSceneEditInfo()
	{
	}

	private void RefreshRoomCard()
	{
	}

	private void ShowGetFreeRoomCardMsgBox(uint reward_creator_times, uint remain_reward_count)
	{
	}

	private void ShowAuthorFreeVFX()
	{
	}

	private void CheckCollobrateActivity()
	{
	}

	private void OnGetActivityAwardFinished(object[] data)
	{
	}

	private void CheckGuides()
	{
	}

	private void CheckFirstEnterGuide()
	{
	}

	private void ShowNewVersionGuideEffect()
	{
	}

	private void OnNewVersionGuideEffectClick()
	{
	}

	private void ShowNewVersionGuide1()
	{
	}

	private void OnNewVersionGuide1Click()
	{
	}

	private void ShowNewVersionGuide2()
	{
	}

	private void ShowGuideSubStep1()
	{
	}

	private void ShowGuideSubStep2()
	{
	}

	private void ShowGuideSubStep3()
	{
	}

	private void OnNewVersionGuide2Click()
	{
	}

	private void AdvanceGuideSubStep()
	{
	}

	private void SetGuideTargetFromBounds(UIWidget guideTarget, Transform sourceTransform)
	{
	}

	private void CloseAllNewVersionGuides()
	{
	}

	private void CancelGuideDelayCall()
	{
	}

	private void CheckFirstViperGuide(Action onComplete = null)
	{
	}

	private void ShowGuideUGCPremiumCard()
	{
	}

	private void OnUGCPremiumRewardWndClosed(int data)
	{
	}

	private void OnUGCPlayerPremiumChanged(int data)
	{
	}

	private void DoAddPopUpTask()
	{
	}

	private void OnPlayPreferenceClosedForPopUp()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnUGCMapPickWndConfirm()
	{
	}

	private void RefreshOptionalResDownload(object[] param)
	{
	}

	private bool RefreshOptionalMapResDownloader()
	{
		return false;
	}

	private void _003COnSelectTab_003Eb__55_0()
	{
	}

	private void _003COnSelectTab_003Eb__55_1()
	{
	}

	private void _003CShowAuthorFreeVFX_003Eb__80_0()
	{
	}

	private void _003CCheckGuides_003Eb__83_0()
	{
	}

	private void _003CCloseAllNewVersionGuides_003Eb__96_0()
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

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
