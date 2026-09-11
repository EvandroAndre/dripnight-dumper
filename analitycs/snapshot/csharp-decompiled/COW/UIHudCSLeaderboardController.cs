using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIHudCSLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__46_1;

		internal int _003CSetTeamCSPeakPoints_003Eb__46_1(int a, int b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public int validItemCount;

		internal bool _003CSetTeamCSPeakPoints_003Eb__0(CSPeakPreTeamPointDesc x)
		{
			return false;
		}
	}

	private bool m_IsSetSelfTeamInfo;

	private bool m_IsSetOppoTeamInfo;

	private bool m_InitClanWarShowState;

	private uint m_WinStreakScrollDelayCallId;

	private int m_WinStreakScrollIndex;

	private bool m_ShowTeamRank;

	private bool m_ShowAvgRank;

	private int m_PlayerRankWeight_1;

	private int m_PlayerRankWeight_2;

	private int m_PlayerRankWeight_3;

	private int m_PlayerRankWeight_4;

	private List<int> m_LeftRanks;

	private List<int> m_RightRanks;

	private const string MAX_RANK_TIP = "T_42_TSY_TEAMRANKMAX";

	private const string AVG_RANK_TIP = "T_42_TSY_TEAMRANKWAVG";

	private Vector3 m_LeftOffset;

	private Vector3 m_RightOffset;

	private UIDetailTipsInGameController m_TipCtrl;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void RefreshCSPeakInfo()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected void RefreshClanInfoInTeamboard()
	{
	}

	protected override void SetInfoType()
	{
	}

	public override void RegisterUIEvent()
	{
	}

	public override void UnRegisterUIEvent()
	{
	}

	private void OnPlayerJoin(GEvent param)
	{
	}

	protected override bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	protected override int SortPlayerData(Transform item2, Transform item1)
	{
		return 0;
	}

	private void Sort(BHGGAEEHJCO pId)
	{
	}

	protected override void OnKillCountChanged(object[] param)
	{
	}

	protected override void OnDeadCountChanged(object[] param)
	{
	}

	protected override void OnTotalDamageChanged(object[] param)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnTeamScoreChange(object[] data)
	{
	}

	private void EndWinStreakScroll()
	{
	}

	private void BeginWinStreakScroll()
	{
	}

	private void DoStreakScroll(bool needScrollStreakIcon)
	{
	}

	private void StreakScroll()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void OnAddPlayer(GEvent param)
	{
	}

	private void SetTeamCSPeakPoints(List<UIHudCSLeaderboardItemController> items, UILabel label, UISprite sprite)
	{
	}

	private void RefreshTeamRank(GEvent param)
	{
	}

	private int GetAverageRank(List<int> ranks)
	{
		return 0;
	}

	private bool SetIcon(List<int> ranks, UISprite sprite)
	{
		return false;
	}

	public int SortDescending(int x, int y)
	{
		return 0;
	}

	private void PressTeamRankBtnTip_Left(GameObject go, bool state)
	{
	}

	private void PressTeamRankBtnTip_Right(GameObject go, bool state)
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
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

	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsTeamOnLeft(BHGGAEEHJCO P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(Transform P0, Transform P1)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnKillCountChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDeadCountChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTotalDamageChanged(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAddPlayer(GEvent P0)
	{
	}
}
