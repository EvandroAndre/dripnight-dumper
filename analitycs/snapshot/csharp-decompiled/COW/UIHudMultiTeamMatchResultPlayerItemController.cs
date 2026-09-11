using GCommon;
using proto;

namespace COW;

public class UIHudMultiTeamMatchResultPlayerItemController : UIHudSingleFightMatchResultItemController
{
	private bool m_Self;

	public TeammateStats DataInfo => null;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void UpdatePlayerData(TeammateStats player)
	{
	}

	protected override void SetIsSelf(bool self)
	{
	}

	public override void ShowLikeContainer(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdatePlayerData(TeammateStats P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetIsSelf(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowLikeContainer(bool P0)
	{
	}
}
