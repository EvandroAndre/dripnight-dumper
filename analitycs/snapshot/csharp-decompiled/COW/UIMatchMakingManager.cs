using System;
using tcp;

namespace COW;

public class UIMatchMakingManager
{
	public enum MentionType
	{
		None,
		ReachHeroicOrMaster,
		ChangeMapMode,
		ChangeGameMode,
		AddMember,
		CreditLow,
		RankNotMatch,
		AutoGroupTimeOut,
		TeammateAlive,
		IsReconnect,
		BeKicked,
		TeammateBeBanMatch,
		SelfBeBanMatch,
		CSPeakOpenTimeEnd,
		JoinedNewGroupInGame
	}

	public enum EDuelState
	{
		CanInvite,
		WaitingResponse,
		TargetRefuse,
		RecieveInvite
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<MapModeData, uint> _003C_003E9__61_0;

		internal uint _003CStartSoloMatchMaking_003Eb__61_0(MapModeData x)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIMatchMakingManager _003C_003E4__this;

		public bool isFriendSpectate;

		public bool isFirstGuideMatch;

		internal void _003COnStartMatchMaking_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public UIMatchMakingManager _003C_003E4__this;

		public bool byClickBtn;

		internal void _003CRequestReady_003Eb__0()
		{
		}
	}

	public uint m_AutoMatchGroupingTime;

	public uint m_AutoMatchMakingTime;

	public uint m_GameModeMatching;

	public uint m_MatchModeMatching;

	public bool DisableQuickMatch;

	public bool IsObserving;

	public MentionType QuickNextMentionType;

	public EDuelState DuelState;

	public bool IsGroupChange;

	public UIMatchMakingWaitingOptimizedController m_MatchmakingWaitingOptimized;

	public UIPostMatchTeamUpCountDownController m_PostMatchTeamUpCountDownController;

	public UIGroupWaitingController m_GroupWaitingCtrl;

	public bool IsReconnect;

	public bool HasBooyah;

	public bool HasInitBriefMatchResult;

	public bool HasInitCSPeakBriefMatchResult;

	public uint LWOutOfTimeDelayCall;

	public bool HasClearDuelState;

	public GroupInviteNtf LatestInviteNtf;

	private uint m_PlayDelayCall;

	private int PanelDepth;

	private int MoveUpObserverSwitchHeight;

	private bool m_IsHidingGroupWaitingForBRReviewRecord;

	private bool m_BRReviewRecordGroupWaitingNeedRestore;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelUser m_ModelUser;

	private UIModelMatch m_ModelMatch;

	private UIModelGroup m_ModelGroup;

	private UIModelHuntingGround m_ModelHuntingGround;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCupMatch m_ModelCupMatch;

	private UICOWBaseScene m_Scene;

	private UIFrontEndScene m_FrontEndScene;

	private UIInGameScene m_InGameScene;

	public static bool IsOriginalReconnect;

	public void OnStartMatchMaking(object[] data)
	{
	}

	public void OnRestartMatchMaking(object[] data)
	{
	}

	public void CheckPlayerCanNeedCancelMatchMaking()
	{
	}

	private void RefreshMatchMakingStateForGroup()
	{
	}

	private void RefreshMatchMakingStateForSolo()
	{
	}

	public void OnEndMatchMaking(object[] data)
	{
	}

	public bool IsFriendSpectateErrorCode(uint errorCode)
	{
		return false;
	}

	public bool IsErrorCodeNeedPopWnd(uint errorCode)
	{
		return false;
	}

	public void OnFromMatchmakingToAutoGroupNtf(object[] data)
	{
	}

	public void SetGroupWaitingView(bool duelMode = false)
	{
	}

	public void UpdateGroupWaitingByAllReadyState()
	{
	}

	public void CloseGroupWaitingView()
	{
	}

	public void ShowGroupWaitingView(bool needResetPos, bool byTcpEvent = false, bool isOBserver = false)
	{
	}

	private bool HideGroupWaitingForRoomMatchMakingViewIfNeeded()
	{
		return false;
	}

	public void HideGroupWaitingView()
	{
	}

	public void HideGroupWaitingForBRReviewRecord()
	{
	}

	public void RestoreGroupWaitingAfterBRReviewRecord()
	{
	}

	private void HideGroupWaitingIfNeededForBRReviewRecord()
	{
	}

	public void ShowMatchMakingView()
	{
	}

	public void HideMatchMakingView()
	{
	}

	public bool CanShowMatchMakingViewNow()
	{
		return false;
	}

	public void ShowPostMatchTeamUpCountDownView()
	{
	}

	public void HidePostMatchTeamUpCountDownView()
	{
	}

	public bool RequestReady(bool byClickBtn = false)
	{
		return false;
	}

	public bool CheckCanSoloMatchMaking()
	{
		return false;
	}

	public void StartSoloMatchMaking()
	{
	}

	public bool RequestPlay()
	{
		return false;
	}

	public void OnGroupStartNtf(object[] data)
	{
	}

	public void OnStopGroupMatchMaking(object[] data)
	{
	}

	public void MoveUpSwitchObserver()
	{
	}

	public void ReShowMatchMaking()
	{
	}

	public void ReShowPostMatchTeamUpCountDown()
	{
	}

	public void ClearEstimateTime()
	{
	}

	public void ClearModeData()
	{
	}

	public void StopMatchMaking()
	{
	}

	public void CloseMatchMaking()
	{
	}

	public void CancelMatchMaking()
	{
	}

	public void ClosePostMatchTeamUpCountDown()
	{
	}

	private void GroupCupAction()
	{
	}

	private void CreatMatchMaking(uint gameMode = 0u, uint matchMode = 0u)
	{
	}

	private bool CreatGroupWaitingInFrontEndScene()
	{
		return false;
	}

	private bool CreatGroupWaitingInGameScene()
	{
		return false;
	}

	public void CreatPostMatchTeamUpCountDown()
	{
	}

	public bool CanShowGroupWaitingViewInFrontEndScene()
	{
		return false;
	}

	public bool CanShowPostMatchTeamUpInFrontEndScene()
	{
		return false;
	}

	public bool IsGroupWaitingDragging()
	{
		return false;
	}

	public bool IsMatchMakingDragging()
	{
		return false;
	}

	private UILobbyLoadoutController GetLoadoutController()
	{
		return null;
	}

	private void _003COnRestartMatchMaking_003Eb__37_0()
	{
	}

	private void _003CRequestPlay_003Eb__62_0()
	{
	}

	private void _003COnGroupStartNtf_003Eb__63_0()
	{
	}

	private void _003CReShowMatchMaking_003Eb__68_0()
	{
	}

	private void _003CReShowMatchMaking_003Eb__68_1()
	{
	}
}
