using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHudUGCTwoTeamMatchResultController : UIHudUGCTeamBattleMatchResultController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnShowDetailUI(bool show)
	{
	}

	protected override bool NeedCountDown()
	{
		return false;
	}

	protected override void RefreshDetailUI(MatchStats stats)
	{
	}

	protected override bool CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO playerID)
	{
		return false;
	}

	protected override bool UseLongTeamList()
	{
		return false;
	}

	private void SetMatch(UGCMatchStats matchStats)
	{
	}

	private void SetTeam(bool isLeftSide, UGCTeamStats teamStats)
	{
	}

	private void SetAllTeammates(bool isLeftSide, List<UGCPlayerStats> playerStats)
	{
	}

	private void ClearDefaultUI()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnShowDetailUI(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedCountDown()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_RefreshDetailUI(MatchStats P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_CheckIsWinTeamPlayerForSpectator(BHGGAEEHJCO P0)
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_UseLongTeamList()
	{
		return false;
	}
}
