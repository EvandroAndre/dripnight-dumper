using COW.GamePlay;
using GCommon;

namespace COW;

internal class UISPHudSinglePlayerItemController : UIEasyListItemController
{
	private UISPHudSinglePlayerItemView m_View;

	private BHGGAEEHJCO m_PlayerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SelectedPlayer(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetPlayerInfo(PlayerData data, int index)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshKingOfKill()
	{
	}

	private void OnKoKPlayerChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
