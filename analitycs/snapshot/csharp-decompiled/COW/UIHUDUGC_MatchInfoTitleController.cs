using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHUDUGC_MatchInfoTitleController : UIHUDUGC_InternalHudController
{
	public class MatchInfoTitleData : UIHUDUGCBaseViewData
	{
		public bool NeedPhaseCountDown;

		public bool NeedRoundNum;

		public bool NeedTeamPlayer;

		public bool NeedTeamScore;

		public bool NeedAliveNum;

		public bool NeedTwoTeam;

		public bool NeedTeammateFlag;

		public int ATeamIndex;

		public int BTeamIndex;

		public int ATeammateFinishedNum;

		public int BTeammateFinishedNum;

		public int TeamIndex;

		public int TeamTargetScore;

		public bool ShowTargetScore;

		public int TeamIndex_MoreTeam;

		public int TeamRank_MoreTeam;

		public bool ShowTeammateFinishNum_MoreTeam;

		public int TeammateFinishNum_MoreTeam;

		public bool ShowTeamTargetScore_MoreTeam;

		public int TeamTargetScore_MoreTeam;

		public int AliveTeammateCount_MoreTeam;

		public int TeamCount_MoreTeam;

		public float PhaseEndTime;
	}

	public class TeamData_MoreTeam
	{
		public int TeamIndex;

		public int TeamRank;

		public int TeammateFinishNum;

		public int TeamTargetScore;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__35_0;

		internal int _003CGetTeammateStates_003Eb__35_0(int a, int b)
		{
			return 0;
		}
	}

	private const int SHOW_MORE_TEAMITEM_COUNT = 2;

	private Color Blue;

	private Color Red;

	private UIHUDUGC_MatchInfoTitleView m_View;

	private MatchInfoTitleData m_ViewData;

	private Dictionary<uint, List<BHGGAEEHJCO>> m_TeammateDict;

	private List<UIHUDUGC_MatchInfoTitle_MoreTeamItemController> m_MoreTeamItemList;

	private Dictionary<int, int> m_MoreTeamRankDict;

	private Dictionary<int, TeamData_MoreTeam> m_MoreTeamDataDict;

	private bool m_IsInit;

	private int m_LastTime;

	private int m_PhaseCountDown;

	private uint m_PlayerHostTeamIndex;

	private bool m_HostTeamRankIsFirst;

	private int m_MaxTargetScore;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetStateByParams(bool isShow, List<GOGJFEJNDLE> args)
	{
	}

	protected override void OnUIInit()
	{
	}

	private void InitView()
	{
	}

	private void OnAddPlayer(GEvent param)
	{
	}

	private void OnPlayerStatusChanged(object[] param)
	{
	}

	private void OnLocalPlayerHPChanged(GEvent data)
	{
	}

	private void OnPhaseEndTimeChanged(object[] data)
	{
	}

	private void OnRoundChanged(object[] data)
	{
	}

	private void OnTeamScoreChanged(object[] data)
	{
	}

	private void UpdateView()
	{
	}

	private void InitViewData()
	{
	}

	private void SetTeamPlayer()
	{
	}

	private void AddTeammateItem(Player player)
	{
	}

	private void UpdateAllTeammateStatus()
	{
	}

	private bool IsLeftTeam(uint teamIndex)
	{
		return false;
	}

	private void SetPhaseCountDown()
	{
	}

	private void UpdatePhaseCountDown()
	{
	}

	private List<int> GetTeammateStates(List<BHGGAEEHJCO> playerIDs)
	{
		return null;
	}

	private void SetTeamPlayerStatus(uint teamIndex, List<int> teammateStates)
	{
	}

	private void SetTeammateFlagCount(uint teamIndex, int count)
	{
	}

	private void SetAliveNum()
	{
	}

	private void SetTeamScore()
	{
	}

	private void SetTargetScore()
	{
	}

	private void UpdateMoreTeamItemList_ForRank(int teamIndex, int teamRank)
	{
	}

	private void UpdateMoreTeamItemList_ForFinishNum()
	{
	}

	private void UpdateMoreTeamItemList_ForTargetScore()
	{
	}

	private void UpdateAliveTeammateCount()
	{
	}

	private UIHUDUGC_MatchInfoTitle_MoreTeamItemController GetMoreTeamItemController(int index)
	{
		return null;
	}

	private TeamData_MoreTeam GetMoreTeamData(int teamIndex)
	{
		return null;
	}

	private void NeedRoundNum(bool value)
	{
	}

	private void Update()
	{
	}

	private void OnClickLeaderboardBtn()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
