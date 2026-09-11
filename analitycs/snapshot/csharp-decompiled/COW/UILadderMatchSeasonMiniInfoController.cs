using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

internal class UILadderMatchSeasonMiniInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private class HCGameInfo
	{
		public string Title;

		public string Value;

		public HCGameInfo(string title, string value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public UILadderMatchSeasonMiniInfoController _003C_003E4__this;

		public MapModeData mapModeData;

		public List<ResourceID> needDownloadRes;

		internal void _003CUpdateRoomMapItemDownloadStatus_003Eb__0()
		{
		}
	}

	private DLBMPCCFKKM m_ChooseLadderMatchType;

	private UILadderMatchSeasonMiniInfoView m_View;

	private GameObject[] m_CSStarArray;

	private GameObject[] m_CSBlackStarArray;

	private Color32 m_LowPointColor;

	private Color32 m_HighPointColor;

	private bool m_hideToggleButton;

	private bool m_showToggle;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelHippoCrisisLadderMatch m_ModelHippoCrisis;

	private UIModelInventory m_ModelInventory;

	private UIModelMapOpeningInfo m_ModelOpeningInfo;

	private UIModelOptionalDownload m_ModelOptionalDownload;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UICenterOnChild m_wrapCenter;

	private int m_LastSelectedIndex;

	private List<UILadderMatchSeasonInfoMissionItemController> m_MissionItems;

	private List<UILadderMatchMissionDotController> m_MissionDotItems;

	private uint m_AutoScrollDelayCallID;

	private int m_ScrollMissionCount;

	private int m_AllMissionCount;

	private MapModeData m_SelectedMapModeData;

	private bool m_NeedDot;

	private const string AnimationName = "play";

	private RankCard m_SelectedRankCard;

	private const string BRLADDERMATCHSEASONTIPS = "BRLADDERMATCHSEASONTIPS_";

	private const string CSLADDERMATCHSEASONTIPS = "CSLADDERMATCHSEASONTIPS_";

	private const string PERIODICLADDERMATCHSEASONTIPS = "PERIODICLADDERMATCHSEASONTIPS_";

	private string m_RankCardContent;

	private string m_RankCardTitle;

	private EShareLadderIconType m_ShareLadderIconType;

	public UINewDownloadInfoController m_Downloader;

	private List<Item> m_RankCardTipItemList;

	private string m_ProtectPointsTipStr;

	private UIProtectionPointCircleController m_ProtectionPointCircleController;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIHippoCrisisRankIconController m_HippoCrisisRankIconController;

	private UIBRRankIconController m_NextBRRankIconCtrl;

	private UICSRankIconController m_NextCSRankIconCtrl;

	private UIHippoCrisisRankIconController m_NextHippoCrisisRankIconController;

	private int m_CSPeakRankScore;

	private int m_BRPeakRankScore;

	private UILeaderBoardTitleIconController m_TitleIconCtrl;

	private GameObject m_NormalFlagUIFX;

	private GameObject m_HippoCrisisFlagUIFX;

	private ResourceID m_NormalFlagUIFXRes;

	private ResourceID m_HippoCrisisFlagUIFXRes;

	private List<UIHippoCrisisGameInfoItemController> m_HCGameInfoCtrlList;

	private List<HCGameInfo> m_HCGameInfoList;

	private string m_ToggleRankKey;

	private UICountDownController m_CountDownCtrl;

	public EShareLadderIconType ShareLadderIconType => EShareLadderIconType.None;

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

	private void OnTweenFinish()
	{
	}

	public void SetViewData(DLBMPCCFKKM ladderMatchType)
	{
	}

	private void RefreshCrossMatchModeView()
	{
	}

	public void ShowLadderRankGuide()
	{
	}

	private void ShowLadderStartGameGuide()
	{
	}

	private void SetWeaponPowerIconVisible(bool isVisible)
	{
	}

	private void UpdateWeaponPowerIconController()
	{
	}

	private void RefreshCSData(object[] data)
	{
	}

	private void RefreshProtectPointIcon(uint rank, uint protectPoint, uint gamemode)
	{
	}

	private void RefreshCSRankIconView(CSLadderRankInfo rankInfo)
	{
	}

	private void TryRefreshCSCrossModeView()
	{
	}

	private void RefreshCSAboveHeroicRank(CSLadderRankInfo userRankInfo)
	{
	}

	private void RefreshCSUnderHeroicRank(CSLadderRankInfo userRankInfo, CSRankData ldata)
	{
	}

	private void RefreshMaxRankTxt(CSLadderRankInfo userRankInfo)
	{
	}

	private void RefreshCSTopTips(bool isSeasonClosed, uint rankStage, CSLadderRankInfo userRankInfo)
	{
	}

	private void RefreshPeriodicData(object[] data)
	{
	}

	private void HidePeriodicDownloader()
	{
	}

	private void RefreshPeriodicTipsTop(bool isSeasonClosed, CSPlayerPeriodicRankingInfoRes userRankInfo)
	{
	}

	private void RefreshPeriodicUnderHeroicRank(CSPlayerPeriodicRankingInfoRes userRankInfo, PeriodicRankData ldata)
	{
	}

	private void RefreshBRData(bool playAni = true)
	{
	}

	private void RefreshBRSeasonOpeningView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	private void RefreshBRSeasonClosedView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	private void RefreshBRTopTips(bool isSeasonClosed, bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	private void RefreshBRSeasonOpeningRankIconView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	private void SetCurBRRankIconView()
	{
	}

	private void TryRefreshBRCrossModeView()
	{
	}

	private void RefreshBRSeasonOpeningScoreAndStarView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	private void RefreshHippoCrisisData(bool playAni = true)
	{
	}

	private void RefreshHippoCrisisRankInfo(CSPlayerHippoRankingInfoRes hcRankInfo)
	{
	}

	private void RefreshHippoCrisisScoreView(CSPlayerHippoRankingInfoRes hcRankInfo)
	{
	}

	private void RefreshHippoCrisisTopTips(bool isSeasonClosed)
	{
	}

	private void RefreshHippoCrisisGameInfoView()
	{
	}

	private void ResetScoreView()
	{
	}

	private void ResetTipRootState()
	{
	}

	private void SetFlagBG()
	{
	}

	private void SetScoreIcon()
	{
	}

	public void RefreshSeasonOpeningDailyMissionData()
	{
	}

	public void RefreshCSSeasonOpeningDailyMissionData()
	{
	}

	private void RefreshDailyMissionAllFinished()
	{
	}

	private void GenerateMissionItems()
	{
	}

	private void SetAutoScrollMission()
	{
	}

	private void RefreshSeasonClosedDailyMissionData()
	{
	}

	private void OnAutoScrollMissionItem()
	{
	}

	private void GetCenterItem(GameObject centerGo)
	{
	}

	private void RefreshStartBtnView(bool isSeasonClosed)
	{
	}

	public void RefreshRankCardState()
	{
	}

	private void SetRankCardContent()
	{
	}

	private void OnRankCardSelectedChange(object[] data)
	{
	}

	private void OnRankCardTipsButtonClick()
	{
	}

	private void OnQuickStartBtn()
	{
	}

	public void UpdatePeriodicDownloaderInfo()
	{
	}

	public void UpdateRoomMapItemDownloadStatus(List<ResourceID> needDownloadRes, MapModeData mapModeData)
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void OnBtnClickRankMasterRuleBtnClick()
	{
	}

	private void OnBtnClickProtectTip()
	{
	}

	private void OnCrossMatchModeBtnClick()
	{
	}

	private void OnBtnClickCSPoint()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void RefreshCurPage()
	{
	}

	public void RefreshToggleAndStartBtnView(bool hideToggleButton)
	{
	}

	public void RefreshToggleRankGroup()
	{
	}

	private void RefreshToggleView(bool isSeasonClosed)
	{
	}

	private void OnToggleRankClick()
	{
	}

	public void RefreshToggleRank()
	{
	}

	public void DelayRefreshTableUI()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__59_0()
	{
	}

	private void _003CShowLadderRankGuide_003Eb__64_0()
	{
	}

	private void _003CRefreshDailyMissionAllFinished_003Eb__99_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
