using COW.GamePlay;
using GCommon;

namespace COW;

public class UILobbyLWObserveNavigationController : UINavigationController, IUIModelDataChangeObserver
{
	private UILobbyLWObserveNavigationView m_View;

	private UIHudFightClubMatchInfoController m_MatchInfoCtrl;

	private BHGGAEEHJCO m_TargetPlayerID;

	private bool m_HasRequestedAddFriend;

	private const string QuitLabelLocKey = "T_48_ZZ_HC_QUIT";

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

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public void RefreshNavigation()
	{
	}

	private void CreateScoreboardChild()
	{
	}

	public void RefreshScoreboard()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnSwitchBtnClick()
	{
	}

	private Player GetSpectatorTargetPlayer()
	{
		return null;
	}

	private void RefreshTargetPlayer()
	{
	}

	private void ClearTargetPlayerInfo()
	{
	}

	private void RefreshTargetBg()
	{
	}

	private void RefreshTargetPlayerBtns(Player player)
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private void OnAntihackBtnClick()
	{
	}

	private bool HasReportedPlayer(ulong userID)
	{
		return false;
	}

	private void OnReportCheatSent(object[] param)
	{
	}

	private void RefreshOperateBtns()
	{
	}

	private bool TryGetLobbyLWObserveBattleInfo(out MNDHKHJINOG.DKIGKFIEFCC battleInfo)
	{
		battleInfo = null;
		return false;
	}

	private void RefreshQuitLabel(bool isResult, MNDHKHJINOG.DKIGKFIEFCC battleInfo)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
