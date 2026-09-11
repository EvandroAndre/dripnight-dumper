using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudCSMatchInfoController : UIBaseController
{
	private struct CSPlayerState
	{
		public UIHudCSPlayerStateInfoView view;

		public ETeammateState state;
	}

	private UIHudCSMatchInfoView m_View;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private List<UIhudCSTechPointView> m_MyTechPointViews;

	private List<UIhudCSTechPointView> m_OppoTechPointViews;

	private List<BHGGAEEHJCO> m_ReplayLocalTeamPlayerIDs;

	private List<BHGGAEEHJCO> m_ReplayOppoTeamPlayerIDs;

	private IJEECINPHFI mGame;

	private uint m_TutorialLeadboardDelayCall;

	private UIModelMatch m_ModelMatch;

	private uint m_BaseTeamCount;

	private uint m_BaseItemSize;

	private uint m_DelayId;

	private bool m_LockScore;

	private uint m_UnlockTeamId;

	private static Color m_TechPointGlowLeftDefaultColor;

	private static Color m_TechPointGlowRightDefaultColor;

	private List<int> m_states;

	private bool m_IsGetTechPointByTechAirdrop;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnShowCSGuideEnemyScore(object[] data)
	{
	}

	private void OnShowCSGuideGameBallLabel(object[] data)
	{
	}

	private void CheckTutorialCSPaused()
	{
	}

	private void OnShowCSGuideFriendScore(object[] data)
	{
	}

	private void OnShowCSGuideScore(object[] data)
	{
	}

	private void OnShowCSGuideHelloKetty(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnBtnLeaderboardClick()
	{
	}

	private void SetUIData()
	{
	}

	private void RefreshTeamStatesUI(BHGGAEEHJCO pId)
	{
	}

	private bool TryGetReplayTeamPlayerIDs(out List<BHGGAEEHJCO> localTeamPlayerIDs, out List<BHGGAEEHJCO> oppoTeamPlayerIDs)
	{
		localTeamPlayerIDs = null;
		oppoTeamPlayerIDs = null;
		return false;
	}

	private void AddReplayTeamPlayerIDs(List<BHGGAEEHJCO> playerIDs, int replayTeamId)
	{
	}

	private void AddReplayTeamPlayerID(BHGGAEEHJCO playerID, int replayTeamId)
	{
	}

	private void SetTeamStatesUI(List<BHGGAEEHJCO> pids, List<UIHudCSPlayerStateInfoView> views, bool isRightSideTeam = true)
	{
	}

	private void Update()
	{
	}

	private void RefreshRemainTimeLabel(int seconds)
	{
	}

	private void OnPlayerRescuredStateChange(uint playerID, uint rescuredState)
	{
	}

	private void OnPlayerHPChanged(GEvent data)
	{
	}

	private void OnPlayerStateChanged(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnShowTutorialLeaderBoard(object[] data)
	{
	}

	private void OnScoreChanged(object[] data)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void OnNewPhaseEnter(object[] data)
	{
	}

	private void OnStartMatchEndShow(object[] data)
	{
	}

	private void SetRoundInfoUI()
	{
	}

	private void UpdateRandomAreaEventStyle()
	{
	}

	private void SetupRandomAreaEventState(bool active)
	{
	}

	private void AdjustRandomAreaEventBgHeight(int height)
	{
	}

	private void OnGetTechPointByTechAirdrop()
	{
	}

	private void OnShowCSMatchScore(uint teamId)
	{
	}

	private void ShowTechPoint()
	{
	}

	private bool IsLocalPlayerWin()
	{
		return false;
	}

	private void OnShowCsTechAirdrop(uint teamId)
	{
	}

	private void ShowUnlockTip(uint teamId)
	{
	}

	private void OnHideTweenTipsWithIcon(int id)
	{
	}

	private void OnShowFinished()
	{
	}

	private void OnShowFinishedDelay()
	{
	}

	private void CancelScoreDelay()
	{
	}

	private void ForceShowScore()
	{
	}

	private void RefreshTechPoint()
	{
	}

	private void RecordTechPointSkinInfo()
	{
	}

	private void SetTechPointSkin()
	{
	}

	private void ResetTechPointSkin()
	{
	}

	private void SetTechPoint(int value, bool isleft)
	{
	}

	private void RefreshUISkinChange()
	{
	}

	private void OnPlayerFFWSFlagChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
