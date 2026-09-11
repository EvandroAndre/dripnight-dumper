using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIHudSingleFightMatchResultItemController : UIHudMatchResultItemBaseController
{
	protected UIHudSingleFightMatchResultItemView m_View;

	private TeammateStats m_Player;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

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

	protected void SetPrivilegeIcon(uint mainType, uint subType)
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
