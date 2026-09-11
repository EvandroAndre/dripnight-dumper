using GCommon;
using proto;

namespace COW;

public class UIHUDRushingPetsPlayerInfoItemController : UIHudSingleFightMatchResultItemController
{
	private bool m_IsLeaderBoard;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetIsInLeaderBoard(bool isLeaderBoard)
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	protected override void UpdatePlayerData(TeammateStats player)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_UpdatePlayerData(TeammateStats P0)
	{
	}
}
