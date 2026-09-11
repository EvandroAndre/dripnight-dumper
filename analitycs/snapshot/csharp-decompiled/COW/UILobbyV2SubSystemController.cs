using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILobbyV2SubSystemController : UIBaseController, ITipsDelegate
{
	private UILobbyV2SubSystemView m_View;

	private UIModelUser m_ModelUser;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelPeriodicLadderMatch m_ModelPeriodicLadderMatch;

	private UIModelSeasonYear m_ModelSeasonYear;

	private UIModelLiveTv m_ModelLiveTv;

	private UIModelQRCode m_ModelQRCode;

	private UITipsNormalController m_LadderTipsCtrl;

	private UITipsNormalController m_LeaderBoardTipsCtrl;

	private UITipsNormalController m_SurveyTipsCtrl;

	private UITipsNormalController m_MileStoneTipsCtrl;

	private UITipsNormalController m_AchievementCtrl;

	private UITipsNormalController m_OnlineMatchTipCtrl;

	private UITipsNormalController m_SeasonYearTipsCtrl;

	private UITipsNormalController m_SeasonReplayTipsCtrl;

	private UICommonGuideController m_CommonGuideCtrl;

	private UIModelLobbyAds.AdInfo m_SurveyAnnouncementData;

	private UILockController m_LadderMatchLockCtrl;

	private UILockController m_LeadBoardLockCtrl;

	private UILockController m_AchievementLockCtrl;

	private UILockController m_AntiHackCenterLockCtrl;

	private UILockController m_EsportsLockCtrl;

	private UILockController m_ClanLockCtrl;

	private UITipsNormalController m_AntiHackCenterTipCtrl;

	private List<int> m_TipsTypeList;

	public UIWidget LadderMatchGuildWidget => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void Show()
	{
	}

	private void RefreshEntranceGroup()
	{
	}

	private void UpdateLevelEntrance(LevelEntranceDataManager.EntranceIdType entranceType)
	{
	}

	private void RefreshAntiHackRedPoint()
	{
	}

	private void RefreshSeasonReplayRedPoint()
	{
	}

	public void UpdateSurveyView()
	{
	}

	private void RefreshSurveyTips()
	{
	}

	private void RefreshAllLadderMatchTips()
	{
	}

	private void RefreshAchievementTips(string content)
	{
	}

	private void RefreshLadderMatchTips()
	{
	}

	private void RefreshLeaderBoardTips()
	{
	}

	private void TryInitTips()
	{
	}

	private void RefreshOnlineMatchBtnTip()
	{
	}

	private void RefreshLiveTvTips()
	{
	}

	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	private void RefreshSeasonYearRedPoint()
	{
	}

	private void OnClose()
	{
	}

	private void OnLadderMatchBtnClick()
	{
	}

	private void OnLeadBoardBtnClick()
	{
	}

	private void OnAchievementBtnClick()
	{
	}

	private void OnAntiHackCenterBtnClick()
	{
	}

	private void OnEsportsBtnClick()
	{
	}

	private void OnSurveyBtnClick()
	{
	}

	private void OnOnlineMatchBtnClick()
	{
	}

	private void OnClickClanBtn()
	{
	}

	private void OnQRCodeScanBtnClick()
	{
	}

	private void UpdateTrainMapsView()
	{
	}

	private void OnTrainMapsBtnClick()
	{
	}

	private void UpdateCustomerServiceView()
	{
	}

	private bool ShouldShowCustomService()
	{
		return false;
	}

	private void OnCustomerServiceBtnClick()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnClickLog(string log)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
