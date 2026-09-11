using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;
using proto;

namespace COW;

public class UILadderMatchNavigationController : UIPreviewNavigationController, IUIModelDataChangeObserver
{
	private enum EPageType
	{
		Normal,
		SeasonSwitch
	}

	public class RewardExhitbitEasyList : IEasyList
	{
		private UILadderMatchNavigationController levelRwardListController;

		public RewardExhitbitEasyList(UILadderMatchNavigationController levelRwardListController)
		{
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UILadderMatchNavigationController _003C_003E4__this;

		public NIKKALKPIBO gameMode;

		public DLBMPCCFKKM matchMode;

		internal void _003CRefreshSeasonEndCountDownView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public DLBMPCCFKKM matchMode;

		internal bool _003CSelectTopTabByMatchMode_003Eb__0(StandardTopTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003CInitDelay_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILadderMatchNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitDelay_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003CShowSeasonReplayGuide_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DLBMPCCFKKM matchMode;

		public UILadderMatchNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowSeasonReplayGuide_003Ed__67(int _003C_003E1__state)
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

	private string SeasonReplayGuideKEY_BR;

	private string SeasonReplayGuideKEY_CS;

	private LadderMatchNavigationView m_View;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelHippoCrisisLadderMatch m_ModelLadderHippoCrisis;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournament;

	private UIModelInventory m_ModelInventory;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelAvatar m_ModelAvatar;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIModelUser m_ModelUser;

	private UIModelSeasonYear m_ModelSeasonYear;

	private UILadderMatchSeasonMiniInfoController m_SeasonMiniInfoCtrl;

	private UILadderMatchLeaderboardController m_LadderBoardCtrl;

	private RewardExhitbitEasyList m_RewardEasyList;

	private UILadderMatchSeasonSwitchController m_SeasonSwtichCtrl;

	private UILadderMatchTopTabController m_TabCtrl;

	private List<StandardTopTabItemViewData> m_TopTabDataList;

	private bool m_HideToggleButton;

	private bool m_IsFirstOpen;

	private NIKKALKPIBO m_ChosenGameMode;

	private DLBMPCCFKKM m_ChosenMatchMode;

	private bool isBRWinPassOpen;

	private bool isCSWinPassOpen;

	private bool m_IsModelAndViewInit;

	private UIPopMenuSmallControler m_PopMenu;

	private EPageType m_PageType;

	private UITipsNormalController m_HistoryTipsCtrl;

	private UITipsNormalController m_RankRewardTipsCtrl;

	private UITipsNormalController m_SeasonYearTipsCtrl;

	private UITipsNormalController m_RankExchangeMallTipsCtrl;

	private UICSPeakTournamentController m_PeakCSRankCtrl;

	private AutoPopup m_AutoPopup;

	private Vector3 m_BooyahpassBtnPos;

	private const uint BOOYAHPASSICONOFFSET = 24u;

	public static List<Type> InterestedModels;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public static void BeforeInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	private StandardTopTabItemViewData CreateCSPeakRankTab()
	{
		return null;
	}

	private void CreateTopTap()
	{
	}

	private void SelectTopTabByMatchMode(DLBMPCCFKKM matchMode)
	{
	}

	private void OnClickClose()
	{
	}

	private void InitViewData()
	{
	}

	private IEnumerator InitDelay()
	{
		return null;
	}

	private void InitModelAndView()
	{
	}

	private void ShowNewBieLadderGuide()
	{
	}

	public void OnBtnRankMissionClick()
	{
	}

	private void TrySetupSeasonThemeLabelGradientColor(PeriodicRankingSeasonInfoDesc lwSeasonInfo)
	{
	}

	private void TrySetupSeasonThemeLabelBgTexture(PeriodicRankingSeasonInfoDesc lwSeasonInfo)
	{
	}

	private void UpdateSeasonRankLabel()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	private void OnLadderMatchLeaderboardBtnClick()
	{
	}

	private void SetData(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}

	private void SetNormalData(DLBMPCCFKKM matchMode)
	{
	}

	private void RefreshSeasonMiniInfoCtrlView()
	{
	}

	private void RefreshNormalMainPageView()
	{
	}

	private void RefreshRightBtnView()
	{
	}

	private IEnumerator ShowSeasonReplayGuide(DLBMPCCFKKM matchMode)
	{
		return null;
	}

	private void OnBtnJmpToLeaderboardClick()
	{
	}

	public void OnBtnHistoryClick()
	{
	}

	private void OnBtnSeasonYearClick()
	{
	}

	private void SendNextGuide()
	{
	}

	private void OnBtnShareClick(object[] data)
	{
	}

	private void OnBtnSeasonReplayClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void SetSeasonCdnBg()
	{
	}

	private void RefreshCurrencyCount()
	{
	}

	private void RefreshHistoryTips()
	{
	}

	private void RefreshRankRewardRedPoint()
	{
	}

	private void RefreshSeasonYearRedPoint()
	{
	}

	private void RefeshRankExchangeMallRedPoint()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void ShowAvatarPreview()
	{
	}

	private void SetNewSeasonIconShowKey()
	{
	}

	private void SetSeasonYearBtnView()
	{
	}

	private bool IsReachRankThreshold()
	{
		return false;
	}

	private bool IsSeasonOpen()
	{
		return false;
	}

	private string GetCdnUrlSeasonBg()
	{
		return null;
	}

	private void OnViewAllBtnClicked()
	{
	}

	public void ShowScreenShotComponent(bool value)
	{
	}

	private void OnScreenshotStart(object[] data)
	{
	}

	private void OnScreenshotFinish(object[] data)
	{
	}

	private void OnExchangMallBtnClick()
	{
	}

	private void OnExchangMallTokenClick()
	{
	}

	private void OnGotoMallExchangeLadderReward()
	{
	}

	private void OnClickSelectGameMode()
	{
	}

	private void UpdatePreviewReward(DLBMPCCFKKM matchMode)
	{
	}

	private void SetRewardEasyList(List<LadderLevelData> datas, int scrollIndex)
	{
	}

	private void OnSelectBR()
	{
	}

	private void OnSelectCS()
	{
	}

	private void OnSelectHippoCrisis()
	{
	}

	private void OnSelectPeakCSRank()
	{
	}

	private void RefreshCSPeakLeaderboardBtn()
	{
	}

	private void HideCSPeakRewardView()
	{
	}

	private void SetNextFirstRankRewardView(DLBMPCCFKKM matchMode)
	{
	}

	private void OnClickBooyahPass()
	{
	}

	private void OnSelectLW()
	{
	}

	private void OnSelectGameMode(object[] data)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshSeasonEndCountDownView(ulong endTime, NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
	}

	private bool CheckIsSeasonSwitchState()
	{
		return false;
	}

	private void SetSeasonSwitchView(bool loadCtrl = true)
	{
	}

	private void _003CCreateCSPeakRankTab_003Eb__47_0()
	{
	}

	private void _003CCreateTopTap_003Eb__48_0()
	{
	}

	private void _003CCreateTopTap_003Eb__48_1()
	{
	}

	private void _003CCreateTopTap_003Eb__48_2()
	{
	}

	private void _003CCreateTopTap_003Eb__48_3()
	{
	}

	private void _003CShowNewBieLadderGuide_003Eb__54_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
