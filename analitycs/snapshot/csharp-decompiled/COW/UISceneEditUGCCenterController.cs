using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UISceneEditUGCCenterController : UINavigationController, IUIModelDataChangeObserver
{
	public enum ETabIndex
	{
		ETabIndex_Recommendation = 0,
		ETabIndex_Category = 1,
		ETabIndex_UserCenter = 2,
		ETabIndex_MyWorks = 3,
		ETabIndex_Room = 4,
		ETabIndex_Subscription = 5,
		ETabIndex_History = 6,
		ETabIndex_PremiumCenter = 7,
		ETabIndex_Rank = 8,
		ETabIndex_Explore = 9,
		ETabIndex_Activity = 10,
		ETabIndex_None = 99
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__36_0;

		internal void _003COnUIInit_003Eb__36_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public string guideKey;

		internal void _003CCheckUserTabLobbyGuide_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public string guideKey;

		internal void _003CCheckUserTabCraftlandGuide_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public UISceneEditUGCCenterController _003C_003E4__this;

		public int value;

		internal void _003CCheckFirstViperGuide_003Eb__0()
		{
		}
	}

	private AutoPopup m_AutoPopup;

	private const float BIGEVENTTEMPALTEYYPOSITION = 85f;

	private UISceneEditUGCCenterView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelUGCPremium m_UGCPremiumModel;

	protected UIRoomCardListController m_RoomCardCtrl;

	protected UIUGCRecommendationV2Controller m_RecommendationV2Ctrl;

	protected UIUGCMyWorksV2Controller m_MyWorksCtrl;

	protected UISceneEditCategoryController m_CategoryCtrl;

	protected UIUGCRoomListController m_RoomListCtrl;

	protected UISceneEditUserCenterController m_UserCenterCtrl;

	protected UIModelSceneEdit m_ModelSceneEdit;

	private UIUGCCenterBigEventTemplateController m_BigEventTemplateController;

	private List<WorkShopCollaborationResources> m_CollaborateResList;

	protected ETabIndex m_SelectedTab;

	private ETabIndex m_NeedSelectedTab;

	private uint m_HideVFXDelayCall;

	private bool m_HaveCategory;

	private bool m_HaveGetModeRule;

	private bool m_SelectSubscription;

	private bool m_NeedCheckAutoDownload;

	public static readonly string Key_GuideUserTab_Craftland_Format;

	public static readonly string Key_GuideUserTab_Lobby_Format;

	public static readonly string Key_Scene_Edit_UGC_Guide;

	public static readonly string Key_UGC_Guide_Step1;

	public static readonly string Key_UGC_Guide_Step2;

	public static readonly string Key_UGC_Guide_Step3;

	public static readonly string Key_UGC_Guide_Step4;

	public static readonly string Key_UGC_Guide_Step5;

	private int m_CategoryTab;

	private UGCSimpleDownloadTask m_NecessaryResDownloadTask;

	public ETabIndex SelectedTab => ETabIndex.ETabIndex_Recommendation;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void Update()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnOldVerisionMaskClick()
	{
	}

	private void CheckCollobrateActivity()
	{
	}

	private void RefreshRoomCard()
	{
	}

	private void CheckGuides()
	{
	}

	private void CheckUserTabLobbyGuide()
	{
	}

	private void CheckUserTabCraftlandGuide()
	{
	}

	private void CheckFirstViperGuide()
	{
	}

	private void OnGetActivityAwardFinished(object[] data)
	{
	}

	private void OnUGCPremiumRewardWndClosed(int data)
	{
	}

	private void OnUGCPlayerPremiumChanged(int data)
	{
	}

	private void OnShowMoreGuideFinished()
	{
	}

	private void CheckFirstEnterGuide()
	{
	}

	private bool ShowUGCGuideStep1()
	{
		return false;
	}

	private void ShowUGCGuideStep2()
	{
	}

	private void ShowUGCGuideStep3()
	{
	}

	private void ShowUGCGuideStep4()
	{
	}

	private void ShowUGCGuideStep5()
	{
	}

	private void ShowGuideUGCPremiumCard()
	{
	}

	private void OnUserCenterClickSubscriptionTab()
	{
	}

	private void OnShowRecommendView(object[] data)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private bool CanClickSceneEditBtn()
	{
		return false;
	}

	private bool CanClickRoomBtn()
	{
		return false;
	}

	private void OnBtnSceneEditClick()
	{
	}

	private void OnUnActiveSceneEditBtnClick()
	{
	}

	private void UpdateSceneEditInfo()
	{
	}

	private void RefreshBigEventTemplate()
	{
	}

	private void OnSelectTab(UIToggleButton button)
	{
	}

	private void InitStandardTabs()
	{
	}

	private void ShowTab(ETabIndex index)
	{
	}

	private void ShowMyWorksTab()
	{
	}

	private void ShowRoomTab(List<object> data)
	{
	}

	private void ShowGetFreeRoomCardMsgBox(uint reward_creator_times, uint remain_reward_count)
	{
	}

	private void ShowAuthorFreeVFX()
	{
	}

	public bool IsShowMyWorks()
	{
		return false;
	}

	public void RefreshPasteRoomIDBtn()
	{
	}

	public void SelectCraftlandTab()
	{
	}

	public void TryAddPopUpTask()
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

	private void _003CCheckFirstEnterGuide_003Eb__49_0()
	{
	}

	private void _003CCheckFirstEnterGuide_003Eb__49_1()
	{
	}

	private void _003COnSelectTab_003Eb__69_0()
	{
	}

	private void _003CShowAuthorFreeVFX_003Eb__75_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
