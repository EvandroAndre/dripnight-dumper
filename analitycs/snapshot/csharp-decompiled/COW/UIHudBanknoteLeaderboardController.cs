using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudBanknoteLeaderboardController : UIBaseController
{
	private UIHudControlLeaderboardView m_View;

	private Dictionary<BHGGAEEHJCO, LeaderboardData> m_ItemsBe4LocalPlayer;

	private Dictionary<BHGGAEEHJCO, UIHudBanknoteLeaderboardItemController> m_ItemControllers;

	private bool m_LocalPlayerAdded;

	private int m_LocalPlayerTeamId;

	private bool m_IsSPFactionUpdated;

	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType1;

	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType2;

	private EMatchResultPlayerInfoType m_MatchResultPlayerInfoType3;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public void SetTitle(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
	{
	}

	private void OnAddPlayer(GEvent param)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void AddItemController(BHGGAEEHJCO pId, LeaderboardData dataInfo)
	{
	}

	private void OnKillCountChanged(object[] param)
	{
	}

	private void OnDMGChanged(object[] param)
	{
	}

	private void OnSyncLeaderBoard(object[] data)
	{
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	private void UpdateFactionInfo()
	{
	}

	private void UpdateFactionInfo(int localFactionID)
	{
	}

	private void OnToggleRoundInfo(object[] parap)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
