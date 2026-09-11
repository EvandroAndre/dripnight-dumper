using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UINewPlayerV3Controller : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private UIStandardTopTabController m_TabCtrl;

	private List<StandardTopTabItemViewData> m_TabDataList;

	private UINewPlayerV3View m_View;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private UICountDownController m_CountDownCtrl;

	private UINewPlayerSurveyController m_SurveyCtrl;

	private UINewPlayerV3MissionController m_MissionCtrl;

	private UINewPlayerV3SubTabMainController m_SubTabCtrl;

	private UINewPlayerV3SignEntranceController m_SignEntranceBubbleCtrl;

	private UINewPlayerV3GrowPathController m_GrowPathCtrl;

	private UINewPlayerV3ExploreCampController m_ExploreCampCtrl;

	private UINewPlayerV3LimitTaskBtnController m_LimitTaskBtnCtrl;

	private FrontEndPreviewComponent m_FrontEndPreviewComponentNewBie;

	private FrontEndPreviewComponent_NewPlayerGrowPath m_FrontEndPreviewComponentGrowPath;

	public int CurDay;

	private NewPlayerTab m_DefaultSelectTab;

	public NewPlayerTab CurTabType;

	private float m_HideSignBubbleTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void InitTabs()
	{
	}

	private void InitUIView()
	{
	}

	private StandardTopTabItemViewData CreatTab(NewPlayerTab newPlayerTab)
	{
		return null;
	}

	private void SetTopTabsVisibility(bool isShow)
	{
	}

	private void RefreshCountDown()
	{
	}

	private void RefreshGameBuffCon()
	{
	}

	private void RefreshSurvey()
	{
	}

	private void RefreshIAPBundle()
	{
	}

	private void RefreshSubTab()
	{
	}

	private void RefreshMission(int day)
	{
	}

	private void RefreshLevelLimitLabel()
	{
	}

	private void RefrehGrowPathCon()
	{
	}

	private void RefreshLimitTaskBtn()
	{
	}

	private void RefreshLimitTaskUI()
	{
	}

	private void RecreateAndRepositionMission()
	{
	}

	private void GotoBigRewardDay(int day)
	{
	}

	private void AutoShowSignEntranceBubble()
	{
	}

	private void RefreshSignEntranceBubble(bool isShow)
	{
	}

	private void AutoOpenDailyRewardPopWnd()
	{
	}

	private bool IsShowSignBubble()
	{
		return false;
	}

	private NewPlayerTab GetGotoTab()
	{
		return NewPlayerTab.NewBieCorner;
	}

	private void OnTabSelected(NewPlayerTab newPlayerTab)
	{
	}

	private void OnSubTabClick(int day)
	{
	}

	private void SelectMain(NewPlayerTab newPlayerTab)
	{
	}

	private void SelectGrowPath(NewPlayerTab newPlayerTab)
	{
	}

	private void SelectExploreCamp(NewPlayerTab newPlayerTab)
	{
	}

	private void GotoDefaultTab()
	{
	}

	private void PlayAnim()
	{
	}

	private void ShowUIView(NewPlayerTab newPlayerTab)
	{
	}

	private void SetTitleName(NewPlayerTab newPlayerTab)
	{
	}

	private void OnBtnGameBufClick()
	{
	}

	private void OnHelpBtnClick()
	{
	}

	private void OnSignEntranceButtonClick()
	{
	}

	private void OnBtnNewBieOfferStoreClick()
	{
	}

	private void OnBtnNewBieTrainClick()
	{
	}

	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	private void ShowDailyBigRewardPreview()
	{
	}

	public void ShowPreviewGrowPath(AwardDesc awardItemInfo, EInventory.AwardType awardType, string previewCDNUrl)
	{
	}

	private void SwitchPreviewType(NewPlayerTab tabType)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override bool DelayPreview()
	{
		return false;
	}

	protected override float DelayPreviewTime()
	{
		return 0f;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CCreatTab_003Eb__27_0()
	{
	}

	private void _003CCreatTab_003Eb__27_1()
	{
	}

	private void _003CCreatTab_003Eb__27_2()
	{
	}

	private void _003CRefreshCountDown_003Eb__29_0()
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

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_DelayPreview()
	{
		return false;
	}

	public float _003C_003EiFixBaseProxy_DelayPreviewTime()
	{
		return 0f;
	}
}
