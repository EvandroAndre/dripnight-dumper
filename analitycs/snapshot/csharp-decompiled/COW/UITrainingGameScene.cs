using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;

namespace COW;

internal class UITrainingGameScene : UIInGameScene
{
	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public HKGAJCJCMPE currentGame;

		public UITrainingGameScene _003C_003E4__this;

		internal void _003COnTryStartOrQuitMiniGame_003Eb__0()
		{
		}
	}

	private sealed class _003COpenCommonHud_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITrainingGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenCommonHud_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003COpenHud_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITrainingGameScene _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COpenHud_003Ed__37(int _003C_003E1__state)
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

	public static bool IsNeedRestoreReadyState;

	private UIHudGameShowInfoController m_ShowInfoCtrl;

	private UIHudTrainingMiniGameController m_MiniGameCtrl;

	private UIHudHumanlikeTargetDamageResultController m_TrainingHumanTargetCtrl;

	private UIHudTrainingShootAreaSetController m_TrainingShootAreaSetController;

	private UIHudTokenComboController m_ComboCtrl;

	private UIHudServeMiniGameInviteController m_MiniGameInviteCtrl;

	private UIHudServerMiniGameReceiveController m_MiniGameReceiveCtrl;

	private UIHudMiniGameMarkController m_MiniGameMarkCtrl;

	private UIHudTrainingVehicleTimerController m_VehicleSpeedTimerCtrl;

	private UIHudTrainingVehicleSpeedActionController m_VehilceSpeedActionCtrl;

	private UIHudFerrisWheelTakePhotoController m_FerrisWheelTakePhotoCtrl;

	private UIHudTrainingDeadSummaryController m_DeadSummaryCtrl;

	private UIHudTrainingGameLineupEndController m_GameLineupEndController;

	private UIHudTrainingGameQueueInfoController m_GameQueueInfoController;

	private UIHudTrainingScoreController m_TrainingScoreCtrl;

	private UIHudRacingShopController m_RacingShopCtrl;

	private UIHudInGameQuitTimerController m_TrainingQuitEndCountDownCtrl;

	private UIHudTrainingQuickSetButtonController m_quickSetBtnCtrl;

	private UIHudTrainingQuickSetController m_quickSetCtrl;

	private UIHudLobbyContainerController m_LobbyContainer;

	private UIHudSocialModeGroupController m_SocialModeGroupController;

	private UIHudSocialChatController m_SocialChatController;

	private UILobbyV2TeamInfoController m_TeamInfoController;

	private UIHudTrainingBattleReviveShoppingController m_TrainingBattleReviveShoppingCtrl;

	private uint m_DelayID;

	private bool m_NeverReceiveMiniGame;

	private GameObject m_BoybandBZone;

	private int m_LastPortal;

	private byte MiniGameQueuePlayerCnt;

	private UIHudFootballGameTimeScoreInfoController m_FootballGameTimeScoreInfoCtrl;

	private UIHudFootballGameLeaderBoardController m_FootballGameLeaderBoardCtrl;

	private UIHudFootballGameMatchResultController m_FootballGameMatchResultCtrl;

	private UIHudFootballGameGoalScoreBannerController m_FootballGameGoalScoreBannerCtrl;

	private UIHudFootballGameCountDownController m_FootballGameCountDownCtrl;

	private UIHudFootballGameInviteController m_FootballGameInviteCtrl;

	private UIHudFootballGameReceiveInviteController m_FootballGameReceiveInviteCtrl;

	private UIHudFootballGameMiniMapController m_FootballGameMiniMapCtrl;

	private UIHudFootballGameTipsController m_FootballGameTips;

	private UIFootballSceneScoreBoardController m_FootballGameSceneScoreBoardCtrl;

	private string[] m_TrainingModeHideChatZoneType;

	private UIHudResetBigHeadController m_ResetBHController;

	private bool m_IsTargetPlayerInfoVisible;

	private bool m_IsActionUIVisible;

	private UIUGCBridgingGameScene m_UGCBridgingGameScene;

	protected override void OnInit()
	{
	}

	private void InitTrainingBattleReviveShoppingCtrl()
	{
	}

	protected Transform FindInGameRankBiliboardRoot()
	{
		return null;
	}

	private void OpenInGameRankBiliboard(Transform biliboardRoot)
	{
	}

	protected override IEnumerator OpenCommonHud()
	{
		return null;
	}

	public void ShowTeamInfoController()
	{
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public override IEnumerator OpenHud()
	{
		return null;
	}

	private void OnShowKillDetail(object[] data)
	{
	}

	private void OnTrainingZoneChanged(object[] data)
	{
	}

	private void CheckRetainQueueInfo()
	{
	}

	private void OnServerMiniGameInvite(object[] data)
	{
	}

	private void OnPlayerLineupEndInfo(object[] data)
	{
	}

	private void OnPlayerInQueueIdxChange(object[] data)
	{
	}

	private void OnQueuePlayerCntChange(object[] data)
	{
	}

	private bool ShouldShowPlayerQueueInfo()
	{
		return false;
	}

	private void OnMiniGameMarkChanged(object[] data)
	{
	}

	private void OnServerMiniGameReceive(object[] data)
	{
	}

	private void OnShowDamageInfo(object[] data)
	{
	}

	private void SetMiniGameRanking()
	{
	}

	private Transform FindMiniGameRoot(OOMGNPFEHMG t)
	{
		return null;
	}

	private void OpenMiniGameRanking(Transform root, OOMGNPFEHMG t)
	{
	}

	private void OnTryStartOrQuitMiniGame(object[] param)
	{
	}

	private void OnShowCombo(object[] data)
	{
	}

	private void OnVehicleSpeedEnterStartPoint(object[] data)
	{
	}

	private void OnVehicleSpeedStart(object[] data)
	{
	}

	private void OnPlayerGetoffVehicle(object[] data)
	{
	}

	private void OnLPQuitVehicleSpeed(object[] data)
	{
	}

	private void OnPlayerGetOnGetOffFerrisWheel(object[] data)
	{
	}

	private void OnDeadSummaryShow(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OpenFootballGameHud()
	{
	}

	public void ShowHideFootballGameHud(bool isShow)
	{
	}

	public void OnFootballGameOpen()
	{
	}

	private void OnPlayerTrainingZoneChange(object[] data)
	{
	}

	private void RefreshChatView(bool isHide)
	{
	}

	protected void OnLocalPlayerBigHeadChange(bool isBigHead)
	{
	}

	private void RefreshResetBHShow()
	{
	}

	private void OnTargetPlayerInfoUIShowChange(bool isShow)
	{
	}

	private void OnActionShowChange(bool isShow)
	{
	}

	private void OnFootballGamePhaseChange(object[] data)
	{
	}

	private void TryShowTeamTips(object[] data)
	{
	}

	private void OnPortalUse(object[] data)
	{
	}

	private void TryShowRacingShop()
	{
	}

	private void OnTrainingHideCountDown()
	{
	}

	private void OnTrainingShowCountDown(object[] data)
	{
	}

	protected override void OnJoinMatchFinished()
	{
	}

	public override UIUGCBridgingGameScene GetUIUGCScene()
	{
		return null;
	}

	private IEnumerator _003C_003En__0()
	{
		return null;
	}

	private IEnumerator _003C_003En__1()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenCommonHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public IEnumerator _003C_003EiFixBaseProxy_OpenHud()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnJoinMatchFinished()
	{
	}

	public UIUGCBridgingGameScene _003C_003EiFixBaseProxy_GetUIUGCScene()
	{
		return null;
	}
}
