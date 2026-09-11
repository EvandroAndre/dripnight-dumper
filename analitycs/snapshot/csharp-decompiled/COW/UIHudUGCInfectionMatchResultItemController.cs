using GCommon;
using proto;

namespace COW;

public class UIHudUGCInfectionMatchResultItemController : UIHudSingleFightMatchResultItemController
{
	private UIHudUGCInfectionMatchResultController m_parentController;

	private UGCPlayerStats m_PlayerStats;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnSetPlayerData(UGCPlayerStats playerStats, bool single)
	{
	}

	private void UpdatePlayerData(UGCPlayerStats playerStats)
	{
	}

	private void ShowBannerVFX(bool show)
	{
	}

	internal void SetParentController(UIHudUGCInfectionMatchResultController parentController)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(UGCPlayerStats P0, bool P1)
	{
	}
}
