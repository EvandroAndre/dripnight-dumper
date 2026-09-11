using GCommon;
using proto;

namespace COW;

public class UIHudUGCSingleFightMatchResultItemController : UIHudMatchResultItemBaseController
{
	protected UIHudUGCSingleFightMatchResultItemView m_View;

	private TeammateStats m_Player;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnSetPlayerData(TeammateStats data, bool single)
	{
	}

	protected virtual void UpdatePlayerData(TeammateStats player)
	{
	}

	private void OnPlatformHeadpicGetted()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSetPlayerData(TeammateStats P0, bool P1)
	{
	}
}
