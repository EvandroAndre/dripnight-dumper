using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudFootballGameLeaderBoardItemController : UIHUDFootballGameLeaderBoardItemBaseController
{
	private const uint ColorTeam1 = 377997311u;

	private const uint ColorTeam2 = 3782358783u;

	private bool m_IsChildOfMatchResult;

	private bool m_FriendAdded;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetChildOfMatchResult()
	{
	}

	protected override void SetInfoLabelList()
	{
	}

	protected override void OnInitData(Player player)
	{
	}

	protected override void OnPlayerAliveStateChanged(uint data)
	{
	}

	private void SetTeamColor(Player player)
	{
	}

	public void SetBg(Player player)
	{
	}

	private void SetBtnAddFriend(Player player)
	{
	}

	protected void OnAddFriendBtnClick()
	{
	}

	private void OnPlayerZoneChange(uint data0, uint data1)
	{
	}

	private void OnPlayerTeamChange(object[] data)
	{
	}

	protected void RebindPlayer()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetInfoLabelList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitData(Player P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPlayerAliveStateChanged(uint P0)
	{
	}
}
